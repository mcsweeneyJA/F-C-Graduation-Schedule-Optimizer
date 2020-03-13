using System.ComponentModel;
using System.Windows;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using System.Reactive.Linq;
using DynamicData;

namespace QUT
{

    using StudyPlan = IEnumerable<QUT.UnitInPlan>;

    public partial class MainWindow : ReactiveWindow<ViewModel>, INotifyPropertyChanged
    {
        public MainWindow()
        {
            this.ViewModel = new ViewModel();

            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                // bind study plan on the left and study areas on the right
                this.OneWayBind(this.ViewModel, vm => vm.enrollableStudyAreas, v => v.StudyAreas.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.semesters, v => v.StudyPlan.ItemsSource);
            });
        }

        // drag and drop data 
        private UIElement dragging = null;
        private Point pickupPoint;

        public UIElement CloneUnitForDragging(string unitCode)
        {
            var clone = new Border();
            clone.Width = 75;
            clone.Height = 50;
            clone.BorderBrush = Brushes.Black;
            clone.BorderThickness = new Thickness(1);
            clone.CornerRadius = new CornerRadius(5);
            clone.Background = Brushes.Pink;
            var stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;
            var textBlock1 = new TextBlock();
            textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock1.FontSize = 14;
            textBlock1.Foreground = Brushes.Blue;
            textBlock1.TextDecorations = TextDecorations.Underline;
            textBlock1.Text = unitCode;
            stackPanel.Children.Add(textBlock1);
            clone.Child = stackPanel;
            return clone;
        }

        private void StartDraggingUnit(string unitCode, UIElement original, MouseButtonEventArgs e)
        {
            // make a clone of the unit that's just been selected and add it to the drag and drop overlay
            pickupPoint = e.GetPosition(original);
            var rootPos = e.GetPosition(Root);
            dragging = CloneUnitForDragging(unitCode);
            dragging.IsHitTestVisible = false;
            // position the clone in the same relative position as the unit just selected
            dragging.SetValue(Canvas.LeftProperty, rootPos.X - pickupPoint.X);
            dragging.SetValue(Canvas.TopProperty, rootPos.Y - pickupPoint.Y);
            DragAndDropOverlay.Children.Add(dragging);
        }

        private async void PickUnitFromStudyArea(object sender, MouseButtonEventArgs e)
        {
            // we've just selected a unit from the current study area and can now drag it onto our study plan
            var element = (FrameworkElement)sender;
            var unitInStudyArea = (UnitInStudyArea)element.DataContext;
            // check that the selected unit is enrollable
            if (unitInStudyArea.statusColour == "Lime") 
            {
                StartDraggingUnit(unitInStudyArea.code, element, e);
                // tell the view model that this unit is now "inflight"
                await ViewModel.PickUnitFromStudyArea.Execute(unitInStudyArea);
            }
        }

        private async void PickUnitFromPlan(object sender, MouseButtonEventArgs e)
        {
            // we've just picked up a unit already in our study plan that we can now either 
            // move to a different semester or remove from plan by dropping elsewhere
            var element = (FrameworkElement)sender;
            var unitInPlan = ((UnitInSemester)element.DataContext).unit;
            StartDraggingUnit(unitInPlan.code, element, e);
            // tell the view model that this unit is now "inflight"
            await ViewModel.PickUnitFromStudyPlan.Execute(unitInPlan);
        }

        private void DragUnit(object sender, MouseEventArgs e)
        {
            // the mouse has moved, so drag the current unit to the new mouse position
            if (dragging != null)
            {
                var pos = e.GetPosition(Root);
                dragging.SetValue(Canvas.LeftProperty, pos.X - pickupPoint.X);
                dragging.SetValue(Canvas.TopProperty, pos.Y - pickupPoint.Y);
            }
        }

        private async void StopDragging()
        {
            DragAndDropOverlay.Children.Remove(dragging);
            dragging = null;
            // tell the view model that this unit is no longer "inflight"
            await ViewModel.DropInflight.Execute();
        }

        private void MouseLeavesApplicationWindow(object sender, MouseEventArgs e)
        {
            // stop dragging unit if mouse leaves the application window
            if (dragging != null)
                StopDragging();
        }

        private async void DropUnitInSemester(object sender, MouseButtonEventArgs e)
        {
            // unit has been dropped into a particular semester in our study plan
            if (dragging != null)
            {
                var element = (FrameworkElement)sender;
                var semesterPlan = (SemesterPlan)element.DataContext;
                // tell the view model to add the currently inflight unit to the study plan
                await ViewModel.ScheduleUnit.Execute(semesterPlan.semester);
                StopDragging();
            }
        }

        private void DropUnitElsewhere(object sender, MouseButtonEventArgs e)
        {
            // if we drop the unit somewhere other than a semester of our study plan
            if (dragging != null)
                StopDragging();
        }

        private async void Optimize_CSharp(object sender, RoutedEventArgs e)
        {
            // users wants us to optimize their current study plan
            // show a progress window (allowing the user to cancel the optimization) until the optimization completes
            var progress = new WizardProgress(ViewModel);
            progress.Show();
            await ViewModel.ApplyWizard.Execute(false);
            progress.Close();
        }

        private async void Optimize_FSharp(object sender, RoutedEventArgs e)
        {
            // users wants us to optimize their current study plan
            // show a progress window (allowing the user to cancel the optimization) until the optimization completes
            var progress = new WizardProgress(ViewModel);
            progress.Show();
            await ViewModel.ApplyWizard.Execute(true);
            progress.Close();
        }

        private async void IN01_Selected(object sender, RoutedEventArgs e)
        {
            // switch to a different course
            await ViewModel.SwitchToIN01.Execute();
            StudyAreas.SelectedIndex = 0;
        }

        private async void EN01_Selected(object sender, RoutedEventArgs e)
        {
            // switch to a different course
            await ViewModel.SwitchToEN01.Execute();
            StudyAreas.SelectedIndex = 0;
        }

        private string mouseOverUnitCode;
        public event PropertyChangedEventHandler PropertyChanged;

        public string MouseOverTitle
        { 
            // get the title of the unit currently under the mouse   
            get 
            {             
                return mouseOverUnitCode != null ? ViewModel.getUnitTitle(mouseOverUnitCode) : "";
            }
        }

        public string MouseOverPrereq
        {
            // get the prereqs for the unit currently under the mouse
            get
            {
                return mouseOverUnitCode != null ? ViewModel.getPrereq(mouseOverUnitCode) : "";
            }
        }

        private void MouseEnterUnitInStudyArea(object sender, MouseEventArgs e)
        {
            // mouse has moved over a new unit
            mouseOverUnitCode = ((Border)sender).Tag.ToString();
            PropertyChanged(this, new PropertyChangedEventArgs("MouseOverTitle"));
            PropertyChanged(this, new PropertyChangedEventArgs("MouseOverPrereq"));
        }

        private void MouseLeaveUnitInStudyArea(object sender, MouseEventArgs e)
        {
            // mouse has left the current unit
            mouseOverUnitCode = null;
            PropertyChanged(this, new PropertyChangedEventArgs("MouseOverTitle"));
            PropertyChanged(this, new PropertyChangedEventArgs("MouseOverPrereq"));
        }
    }
}


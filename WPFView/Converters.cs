using System.Collections.Generic;
using System.Windows.Data;
using System.Windows.Media;
using System;
using System.Globalization;


namespace QUT
{
    // Helper converter for converting from ViewModel properties to visual properties
    public class MyConverter : IValueConverter
    {
        protected Dictionary<object, object> mapping = new Dictionary<object, object>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (mapping.ContainsKey(value))
                return mapping[value];
            else
                return mapping["default"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class AlternateRowColours : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var semester = (QUT.Semester)value;
            // if this is semester in the past, show in a slightly different colour
            if (semester.CompareTo(FSharpSchedulingWizard.currentSemester) < 0)
            {
                if (semester.offering == QUT.Offering.Semester1)
                    return "#DDE";
                else if (semester.offering == QUT.Offering.Semester2)
                    return "#CCD";
                else
                    return "#DFF";
            }
            else
            {
                if (semester.offering == QUT.Offering.Semester1)
                    return "#EDD";
                else if (semester.offering == QUT.Offering.Semester2)
                    return "#DCC";
                else
                    return "#DFD";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SemesterEnrollable : MyConverter
    {
        // while unit is inFlight, show which semesters it can be dropped into
        public SemesterEnrollable()
        {
            mapping[true] = Brushes.Lime;
            mapping[false] = Brushes.Transparent;
        }
    }

    public class HighlightCoreUnits : MyConverter
    {
        // Highlight core units with a red label
        public HighlightCoreUnits()
        {
            mapping["Core"] = "Red";
            mapping["default"] = "Black";
        }
    }
}

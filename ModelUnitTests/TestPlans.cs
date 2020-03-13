using System.Collections.Generic;
using QUT;

namespace ModelUnitTests
{
    using StudyPlan = IEnumerable<UnitInPlan>;

    public class TestPlans
    {
        public static StudyPlan IllegalPlan101()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_2_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_2_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_4_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_4_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_4_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_4_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_7_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_7_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_7_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_9a_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01MNR-NETWSEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9a_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("CAB240", "IN01MNR-NETWSEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9a_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01MNR-NETWSEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9b_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9b_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9b_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_9c_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_9c_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_9_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_9_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_9_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_9_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_12a_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_12a_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_12a_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_12b_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_12b_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_12b_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_12b_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_12b_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_5()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_14_6()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_16a_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_16a_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16a_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16a_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16b_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16b_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_16b_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16b_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_16b_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_16b_5()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_18_5()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20a_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20a_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20a_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20a_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20b_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_20b_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_20b_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_20b_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2025, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_20b_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_20c_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2025, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_5()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan IN01_20c_6()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2024, Offering.Semester1)));
            return plan;
        }

        public static StudyPlan EN01_21_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_21_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_21_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2025, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_21_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-SOFTENG", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_21_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-SOFTENG", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_4()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_5()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan IN01_24_6()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB103", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB102", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "IN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB339", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "IN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB303", "IN01MJR-COMPSC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MXB103", "IN01MNR-INTLSYS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB295", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "IN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB398", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB399", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB440", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB420", "IN01MNR-INTLSYS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB441", "IN01MNR-NETWSEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "IN01MJR-COMPSC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "IN01MJR-COMPSC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB340", "IN01MNR-NETWSEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB302", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "IN01MNR-INTLSYS", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "IN01MJR-COMPSC", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_32_0()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB432", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-INFOTEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH404", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-INFOTEC", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB401", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH446", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-1", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-2", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-INFOTEC", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH445", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_32_1()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB432", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-INFOTEC", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH404", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH446", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "INENMNR-SOFTENG", new Semester(2024, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-1", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "INENMNR-INFOTEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-2", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH445", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_32_2()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("CAB240", "INENMNR-INFOTEC", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-INFOTEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB210", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB320", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH404", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB432", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH446", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-1", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH400-2", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH445", "EN01MJR-COMSOFT", new Semester(2025, Offering.Semester2)));
            return plan;
        }

        public static StudyPlan EN01_32_3()
        {
            var plan = new List<UnitInPlan>();
            plan.Add(new UnitInPlan("EGB100", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB125", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB104", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB201", "EN01MJR-COMSOFT", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB203", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB111", "EN01-COREUNITS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("IFB105", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB120", "EN01-COREUNITS", new Semester(2020, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB113", "EN01-COREUNITS", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB230", "INENMNR-INFOTEC", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB302", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB121", "EN01-COREUNITS", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB402", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("MZB126", "EN01-COREUNITS", new Semester(2021, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB242", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB240", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB320", "INENMNR-SOFTENG", new Semester(2022, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGB345", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB202", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH446", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB403", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH456", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("CAB301", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH455", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGB240", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH404", "EN01MJR-COMSOFT", new Semester(2022, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB401", "INENMNR-SOFTENG", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB432", "EN01MJR-COMSOFT", new Semester(2021, Offering.Semester2)));
            plan.Add(new UnitInPlan("CAB210", "INENMNR-INFOTEC", new Semester(2020, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH400-1", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            plan.Add(new UnitInPlan("EGH400-2", "EN01MJR-COMSOFT", new Semester(2024, Offering.Semester1)));
            plan.Add(new UnitInPlan("EGH445", "EN01MJR-COMSOFT", new Semester(2023, Offering.Semester2)));
            return plan;
        }


        public static List<StudyPlan> allPlans()
        {
            return new List<StudyPlan> { IllegalPlan101(), IN01_2_0(), IN01_2_1(), IN01_4_0(), IN01_4_1(), IN01_4_2(), IN01_4_3(), EN01_7_0(), EN01_7_1(), EN01_7_2(), IN01_9a_0(), IN01_9a_1(), IN01_9a_2(), IN01_9b_0(), IN01_9b_1(), IN01_9b_2(), IN01_9c_0(), IN01_9c_1(), EN01_9_0(), EN01_9_1(), EN01_9_2(), EN01_9_3(), IN01_12a_0(), IN01_12a_1(), IN01_12a_2(), IN01_12b_0(), IN01_12b_1(), IN01_12b_2(), IN01_12b_3(), IN01_12b_4(), IN01_14_0(), IN01_14_1(), IN01_14_2(), IN01_14_3(), IN01_14_4(), IN01_14_5(), IN01_14_6(), IN01_16a_0(), IN01_16a_1(), IN01_16a_2(), IN01_16a_3(), IN01_16b_0(), IN01_16b_1(), IN01_16b_2(), IN01_16b_3(), IN01_16b_4(), IN01_16b_5(), EN01_18_0(), EN01_18_1(), EN01_18_2(), EN01_18_3(), EN01_18_4(), EN01_18_5(), IN01_20a_0(), IN01_20a_1(), IN01_20a_2(), IN01_20a_3(), IN01_20b_0(), IN01_20b_1(), IN01_20b_2(), IN01_20b_3(), IN01_20b_4(), IN01_20c_0(), IN01_20c_1(), IN01_20c_2(), IN01_20c_3(), IN01_20c_4(), IN01_20c_5(), IN01_20c_6(), EN01_21_0(), EN01_21_1(), EN01_21_2(), EN01_21_3(), EN01_21_4(), IN01_24_0(), IN01_24_1(), IN01_24_2(), IN01_24_3(), IN01_24_4(), IN01_24_5(), IN01_24_6(), EN01_32_0(), EN01_32_1(), EN01_32_2(), EN01_32_3() };
        }

        public static List<StudyPlan> legalPlans()
        {
            return new List<StudyPlan> { IN01_2_0(), IN01_2_1(), IN01_4_0(), IN01_4_1(), IN01_4_2(), IN01_4_3(), EN01_7_0(), EN01_7_1(), EN01_7_2(), IN01_9a_0(), IN01_9a_1(), IN01_9a_2(), IN01_9b_0(), IN01_9b_1(), IN01_9b_2(), IN01_9c_0(), IN01_9c_1(), EN01_9_0(), EN01_9_1(), EN01_9_2(), EN01_9_3(), IN01_12a_0(), IN01_12a_1(), IN01_12a_2(), IN01_12b_0(), IN01_12b_1(), IN01_12b_2(), IN01_12b_3(), IN01_12b_4(), IN01_14_0(), IN01_14_1(), IN01_14_2(), IN01_14_3(), IN01_14_4(), IN01_14_5(), IN01_14_6(), IN01_16a_0(), IN01_16a_1(), IN01_16a_2(), IN01_16a_3(), IN01_16b_0(), IN01_16b_1(), IN01_16b_2(), IN01_16b_3(), IN01_16b_4(), IN01_16b_5(), EN01_18_0(), EN01_18_1(), EN01_18_2(), EN01_18_3(), EN01_18_4(), EN01_18_5(), IN01_20a_0(), IN01_20a_1(), IN01_20a_2(), IN01_20a_3(), IN01_20b_0(), IN01_20b_1(), IN01_20b_2(), IN01_20b_3(), IN01_20b_4(), IN01_20c_0(), IN01_20c_1(), IN01_20c_2(), IN01_20c_3(), IN01_20c_4(), IN01_20c_5(), IN01_20c_6(), EN01_21_0(), EN01_21_1(), EN01_21_2(), EN01_21_3(), EN01_21_4(), IN01_24_0(), IN01_24_1(), IN01_24_2(), IN01_24_3(), IN01_24_4(), IN01_24_5(), IN01_24_6(), EN01_32_0(), EN01_32_1(), EN01_32_2(), EN01_32_3() };
        }
    }
}

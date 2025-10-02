
using System;
using System.Collections.Generic; 

namespace LINQTut05.Shared
{
    public static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
    {
        new Employee
        {
            Index = 1,
            EmployeeNo = "2017-FI-1343",
            Name = "Cochran Cole",
            Email = "Cole.Cochran01@example.com",
            Salary = 1032,
            Skills = new() { "Javascript", "C++", "NodeJS" }
        },
        new Employee
        {
            Index = 2,
            EmployeeNo = "2018-FI-1755",
            Name = "Jaclyn Wolfe",
            Email = "Wolfe.Jaclyn@example.com",
            Salary = 1924,
            Skills = new() { "C#", "Javascript", "ASP.NET" }
        },
        new Employee
        {
            Index = 3,
            EmployeeNo = "2016-IT-1441",
            Name = "Cochran Cole",
            Email = "Cole.Cochran02@example.com",
            Salary = 1728,
            Skills = new() { "ASP.NET", "Javascript" }
        },
        new Employee
        {
            Index = 4,
            EmployeeNo = "2016-FI-3447",
            Name = "Hester Evans",
            Email = "Evans.Hester@example.com",
            Salary = 1555,
            Skills = new() { "CSS", "Javascript", "NodeJS" }
        },
        new Employee
        {
            Index = 5,
            EmployeeNo = "2014-IT-2956",
            Name = "Wallace Buck",
            Email = "Buck.Wallace@example.com",
            Salary = 3158,
            Skills = new() { "Oracle", "HTML", "CSS" }
        },
        new Employee
        {
            Index = 6,
            EmployeeNo = "2020-IT-6341",
            Name = "Acevedo Wall",
            Email = "Wall.Acevedo@example.com",
            Salary = 3437,
            Skills = new() { "ASP.NET" }
        },
        new Employee
        {
            Index = 7,
            EmployeeNo = "2021-IT-4488",
            Name = "Jacqueline Pickett",
            Email = "Pickett.Jacqueline@example.com",
            Salary = 3700,
            Skills = new() { "NodeJS" }
        },
        new Employee
        {
            Index = 8,
            EmployeeNo = "2017-HR-3248",
            Name = "Oconnor Espinoza",
            Email = "Espinoza.Oconnor@example.com",
            Salary = 1556,
            Skills = new() { "SQL Server", "C#", "HTML", "C++" }
        },
        new Employee
        {
            Index = 9,
            EmployeeNo = "2020-AC-9097",
            Name = "Allie Elliott",
            Email = "Elliott.Allie@example.com",
            Salary = 3154,
            Skills = new() { "Oracle" }
        },
        new Employee
        {
            Index = 10,
            EmployeeNo = "2016-HR-3770",
            Name = "Elva Decker",
            Email = "Decker.Elva@example.com",
            Salary = 3459,
            Skills = new() { "ASP.NET", "Javascript", "C#" }
        },
        new Employee
        {
            Index = 11,
            EmployeeNo = "2020-HR-8809",
            Name = "Hayes Beasley",
            Email = "Beasley.Hayes@example.com",
            Salary = 3727,
            Skills = new() { "SQL Server", "C++", "NodeJS", "Oracle", "Javascript" }
        },
        new Employee
        {
            Index = 12,
            EmployeeNo = "2015-FI-3038",
            Name = "Florine Cervantes",
            Email = "Cervantes.Florine@example.com",
            Salary = 3387,
            Skills = new() { "HTML" }
        },
        new Employee
        {
            Index = 13,
            EmployeeNo = "2017-AC-7409",
            Name = "Bullock Carney",
            Email = "Carney.Bullock@example.com",
            Salary = 2144,
            Skills = new() { "C++", "CSS" }
        },
        new Employee
        {
            Index = 14,
            EmployeeNo = "2021-FI-3725",
            Name = "Carroll Cantu",
            Email = "Cantu.Carroll@example.com",
            Salary = 3432,
            Skills = new() { "C++", "C#" }
        },
        new Employee
        {
            Index = 15,
            EmployeeNo = "2019-IT-9738",
            Name = "Debra Hogan",
            Email = "Hogan.Debra@example.com",
            Salary = 2491,
            Skills = new() { "Oracle", "NodeJS", "HTML", "ASP.NET" }
        },
        new Employee
        {
            Index = 16,
            EmployeeNo = "2019-IT-7184",
            Name = "Winnie Mccall",
            Email = "Mccall.Winnie@example.com",
            Salary = 2873,
            Skills = new() { "CSS", "HTML" }
        },
        new Employee
        {
            Index = 17,
            EmployeeNo = "2015-IT-4664",
            Name = "Manuela Berger",
            Email = "Berger.Manuela@example.com",
            Salary = 1725,
            Skills = new() { "Oracle" }
        },
        new Employee
        {
            Index = 18,
            EmployeeNo = "2017-IT-3609",
            Name = "Lakeisha Lowe",
            Email = "Lowe.Lakeisha@example.com",
            Salary = 3143,
            Skills = new() { "NodeJS", "Oracle", "CSS", "ASP.NET" }
        },
        new Employee
        {
            Index = 19,
            EmployeeNo = "2016-FI-2682",
            Name = "Stewart Lott",
            Email = "Lott.Stewart@example.com",
            Salary = 1466,
            Skills = new() { "ASP.NET", "C#", "Javascript", "SQL Server", "HTML" }
        },
        new Employee
        {
            Index = 20,
            EmployeeNo = "2014-IT-3754",
            Name = "Stafford Peck",
            Email = "Peck.Stafford@example.com",
            Salary = 3207,
            Skills = new() { "C++", "ASP.NET" }
        },
        new Employee
        {
            Index = 21,
            EmployeeNo = "2020-HR-7462",
            Name = "Barron Bird",
            Email = "Bird.Barron@example.com",
            Salary = 1512,
            Skills = new() { "NodeJS", "Javascript", "ASP.NET" }
        },
        new Employee
        {
            Index = 22,
            EmployeeNo = "2015-IT-5171",
            Name = "Nona Brooks",
            Email = "Brooks.Nona@example.com",
            Salary = 1365,
            Skills = new() { "HTML", "NodeJS" }
        },
        new Employee
        {
            Index = 23,
            EmployeeNo = "2014-IT-6267",
            Name = "Clara Reeves",
            Email = "Reeves.Clara@example.com",
            Salary = 2458,
            Skills = new() { "ASP.NET", "NodeJS" }
        },
        new Employee
        {
            Index = 24,
            EmployeeNo = "2018-IT-8208",
            Name = "Karin Blanchard",
            Email = "Blanchard.Karin@example.com",
            Salary = 3412,
            Skills = new() { "C#", "SQL Server", "NodeJS", "CSS", "HTML" }
        },
        new Employee
        {
            Index = 25,
            EmployeeNo = "2019-AC-8905",
            Name = "Burris Morgan",
            Email = "Morgan.Burris@example.com",
            Salary = 3603,
            Skills = new() { "C++", "CSS", "ASP.NET", "Oracle" }
        },
        new Employee
        {
            Index = 26,
            EmployeeNo = "2021-IT-7496",
            Name = "Owen Cortez",
            Email = "Cortez.Owen@example.com",
            Salary = 1937,
            Skills = new() { "Oracle", "Javascript", "C++", "NodeJS", "HTML" }
        },
        new Employee
        {
            Index = 27,
            EmployeeNo = "2016-AC-4762",
            Name = "Letha Finch",
            Email = "Finch.Letha@example.com",
            Salary = 3572,
            Skills = new() { "Oracle", "CSS", "NodeJS", "C#", "ASP.NET" }
        },
        new Employee
        {
            Index = 28,
            EmployeeNo = "2016-AC-2518",
            Name = "Sondra Rojas",
            Email = "Rojas.Sondra@example.com",
            Salary = 3097,
            Skills = new() { "Javascript", "SQL Server" }
        },
        new Employee
        {
            Index = 29,
            EmployeeNo = "2020-HR-9123",
            Name = "Hoover Cook",
            Email = "Cook.Hoover@example.com",
            Salary = 2822,
            Skills = new() { "Oracle", "ASP.NET", "Javascript", "CSS" }
        },
        new Employee
        {
            Index = 30,
            EmployeeNo = "2021-AC-5938",
            Name = "Wanda Bender",
            Email = "Bender.Wanda@example.com",
            Salary = 2942,
            Skills = new() { "SQL Server", "Javascript", "NodeJS", "C#", "CSS" }
        },
        new Employee
        {
            Index = 31,
            EmployeeNo = "2020-AC-6792",
            Name = "Sanford Craig",
            Email = "Craig.Sanford@example.com",
            Salary = 2782,
            Skills = new() { "NodeJS" }
        },
        new Employee
        {
            Index = 32,
            EmployeeNo = "2021-FI-7673",
            Name = "Christy Middleton",
            Email = "Middleton.Christy@example.com",
            Salary = 3774,
            Skills = new() { "CSS", "C#" }
        },
        new Employee
        {
            Index = 33,
            EmployeeNo = "2019-HR-7369",
            Name = "Day Brady",
            Email = "Brady.Day@example.com",
            Salary = 1426,
            Skills = new() { "SQL Server", "Oracle", "C++", "CSS", "ASP.NET" }
        },
        new Employee
        {
            Index = 34,
            EmployeeNo = "2014-FI-2740",
            Name = "Powers Beard",
            Email = "Beard.Powers@example.com",
            Salary = 2240,
            Skills = new() { "NodeJS", "HTML" }
        },
        new Employee
        {
            Index = 35,
            EmployeeNo = "2017-FI-6079",
            Name = "Arline Pratt",
            Email = "Pratt.Arline@example.com",
            Salary = 3603,
            Skills = new() { "Javascript", "Oracle" }
        },
        new Employee
        {
            Index = 36,
            EmployeeNo = "2017-AC-5189",
            Name = "Sharpe Cardenas",
            Email = "Cardenas.Sharpe@example.com",
            Salary = 2661,
            Skills = new() { "HTML", "SQL Server", "ASP.NET", "Oracle", "C++" }
        },
        new Employee
        {
            Index = 37,
            EmployeeNo = "2020-AC-6920",
            Name = "Madeleine Stanton",
            Email = "Stanton.Madeleine@example.com",
            Salary = 1983,
            Skills = new() { "C#" }
        },
        new Employee
        {
            Index = 38,
            EmployeeNo = "2014-FI-8160",
            Name = "Spears Noble",
            Email = "Noble.Spears@example.com",
            Salary = 1763,
            Skills = new() { "C#", "HTML" }
        },
        new Employee
        {
            Index = 39,
            EmployeeNo = "2021-IT-7542",
            Name = "Gonzalez Gilliam",
            Email = "Gilliam.Gonzalez@example.com",
            Salary = 3943,
            Skills = new() { "Oracle", "CSS", "ASP.NET" }
        },
        new Employee
        {
            Index = 40,
            EmployeeNo = "2018-FI-1312",
            Name = "Abigail Bradford",
            Email = "Bradford.Abigail@example.com",
            Salary = 2961,
            Skills = new() { "C#", "ASP.NET", "HTML", "NodeJS", "CSS" }
        },
        new Employee
        {
            Index = 41,
            EmployeeNo = "2020-IT-4198",
            Name = "Ashlee Farmer",
            Email = "Farmer.Ashlee@example.com",
            Salary = 1253,
            Skills = new() { "Javascript", "C++", "SQL Server" }
        },
        new Employee
        {
            Index = 42,
            EmployeeNo = "2014-IT-7772",
            Name = "Glover Lloyd",
            Email = "Lloyd.Glover@example.com",
            Salary = 1230,
            Skills = new() { "Oracle", "CSS" }
        },
        new Employee
        {
            Index = 43,
            EmployeeNo = "2018-IT-4562",
            Name = "Cleo Mays",
            Email = "Mays.Cleo@example.com",
            Salary = 2149,
            Skills = new() { "SQL Server", "NodeJS" }
        },
        new Employee
        {
            Index = 44,
            EmployeeNo = "2021-IT-4227",
            Name = "Patrice House",
            Email = "House.Patrice@example.com",
            Salary = 1245,
            Skills = new() { "Javascript", "CSS", "Oracle", "C#" }
        },
        new Employee
        {
            Index = 45,
            EmployeeNo = "2015-AC-6366",
            Name = "Atkins Shannon",
            Email = "Shannon.Atkins@example.com",
            Salary = 1366,
            Skills = new() { "Oracle", "HTML" }
        },
        new Employee
        {
            Index = 46,
            EmployeeNo = "2016-AC-1212",
            Name = "Luisa Hopkins",
            Email = "Hopkins.Luisa@example.com",
            Salary = 1929,
            Skills = new() { "C++", "ASP.NET", "Javascript", "Oracle" }
        },
        new Employee
        {
            Index = 47,
            EmployeeNo = "2016-IT-4794",
            Name = "Kaufman Gross",
            Email = "Gross.Kaufman@example.com",
            Salary = 2236,
            Skills = new() { "ASP.NET", "HTML", "C#", "CSS", "SQL Server" }
        },
        new Employee
        {
            Index = 48,
            EmployeeNo = "2014-HR-4395",
            Name = "William Clay",
            Email = "Clay.William@example.com",
            Salary = 2375,
            Skills = new() { "Javascript" }
        },
        new Employee
        {
            Index = 49,
            EmployeeNo = "2014-IT-1387",
            Name = "Alison Kirby",
            Email = "Kirby.Alison@example.com",
            Salary = 3548,
            Skills = new() { "Javascript" }
        },
        new Employee
        {
            Index = 50,
            EmployeeNo = "2014-AC-7846",
            Name = "Morrow Lynch",
            Email = "Lynch.Morrow@example.com",
            Salary = 2814,
            Skills = new() { "ASP.NET", "C#" }
        },
        new Employee
        {
            Index = 51,
            EmployeeNo = "2019-IT-3225",
            Name = "Roach Bright",
            Email = "Bright.Roach@example.com",
            Salary = 3267,
            Skills = new() { "Javascript", "SQL Server", "NodeJS", "ASP.NET", "C#" }
        },
        new Employee
        {
            Index = 52,
            EmployeeNo = "2019-FI-6985",
            Name = "Carolyn Justice",
            Email = "Justice.Carolyn@example.com",
            Salary = 1431,
            Skills = new() { "HTML", "C++", "ASP.NET", "Javascript", "Oracle" }
        },
        new Employee
        {
            Index = 53,
            EmployeeNo = "2016-FI-6331",
            Name = "Cathryn Mathews",
            Email = "Mathews.Cathryn@example.com",
            Salary = 3660,
            Skills = new() { "C++" }
        },
        new Employee
        {
            Index = 54,
            EmployeeNo = "2016-AC-2870",
            Name = "Lindsay Pruitt",
            Email = "Pruitt.Lindsay@example.com",
            Salary = 1073,
            Skills = new() { "C#", "NodeJS", "HTML" }
        },
        new Employee
        {
            Index = 55,
            EmployeeNo = "2016-AC-9730",
            Name = "Cummings Webster",
            Email = "Webster.Cummings@example.com",
            Salary = 2227,
            Skills = new() { "Oracle", "NodeJS" }
        },
        new Employee
        {
            Index = 56,
            EmployeeNo = "2017-AC-5421",
            Name = "Cannon Pace",
            Email = "Pace.Cannon@example.com",
            Salary = 3450,
            Skills = new() { "HTML" }
        },
        new Employee
        {
            Index = 57,
            EmployeeNo = "2017-AC-1564",
            Name = "Barber Singleton",
            Email = "Singleton.Barber@example.com",
            Salary = 1924,
            Skills = new() { "Javascript" }
        },
        new Employee
        {
            Index = 58,
            EmployeeNo = "2018-AC-8647",
            Name = "Aileen Sweet",
            Email = "Sweet.Aileen@example.com",
            Salary = 2624,
            Skills = new() { "CSS", "Javascript", "C++" }
        },
        new Employee
        {
            Index = 59,
            EmployeeNo = "2014-FI-1877",
            Name = "Lindsey Hughes",
            Email = "Hughes.Lindsey@example.com",
            Salary = 3700,
            Skills = new() { "SQL Server", "C++", "CSS", "C#", "Oracle" }
        },
        new Employee
        {
            Index = 60,
            EmployeeNo = "2019-FI-5494",
            Name = "Stout Phillips",
            Email = "Phillips.Stout@example.com",
            Salary = 1510,
            Skills = new() { "Oracle" }
        },
        new Employee
        {
            Index = 61,
            EmployeeNo = "2021-AC-4682",
            Name = "Benjamin Stephens",
            Email = "Stephens.Benjamin@example.com",
            Salary = 3996,
            Skills = new() { "C#", "NodeJS", "CSS" }
        },
        new Employee
        {
            Index = 62,
            EmployeeNo = "2018-AC-8818",
            Name = "Mandy Odom",
            Email = "Odom.Mandy@example.com",
            Salary = 2264,
            Skills = new() { "SQL Server" }
        },
        new Employee
        {
            Index = 63,
            EmployeeNo = "2017-AC-8946",
            Name = "Hays Austin",
            Email = "Austin.Hays@example.com",
            Salary = 2920,
            Skills = new() { "C#", "Oracle", "C++", "CSS", "ASP.NET" }
        },
        new Employee
        {
            Index = 64,
            EmployeeNo = "2020-HR-2271",
            Name = "Jean Salas",
            Email = "Salas.Jean@example.com",
            Salary = 2116,
            Skills = new() { "HTML", "SQL Server", "Javascript", "Oracle", "ASP.NET" }
        },
        new Employee
        {
            Index = 65,
            EmployeeNo = "2021-HR-3289",
            Name = "Luann Hubbard",
            Email = "Hubbard.Luann@example.com",
            Salary = 3016,
            Skills = new() { "Oracle" }
        },
        new Employee
        {
            Index = 66,
            EmployeeNo = "2021-IT-2893",
            Name = "Eaton Lyons",
            Email = "Lyons.Eaton@example.com",
            Salary = 2376,
            Skills = new() { "C#", "CSS", "Javascript", "ASP.NET" }
        },
        new Employee
        {
            Index = 67,
            EmployeeNo = "2015-HR-7939",
            Name = "Beck Ortiz",
            Email = "Ortiz.Beck@example.com",
            Salary = 1929,
            Skills = new() { "CSS", "C#", "SQL Server", "HTML" }
        },
        new Employee
        {
            Index = 68,
            EmployeeNo = "2017-IT-8169",
            Name = "Patty Knight",
            Email = "Knight.Patty@example.com",
            Salary = 1731,
            Skills = new() { "NodeJS", "SQL Server", "Oracle" }
        },
        new Employee
        {
            Index = 69,
            EmployeeNo = "2017-IT-8048",
            Name = "Bowman Hampton",
            Email = "Hampton.Bowman@example.com",
            Salary = 1452,
            Skills = new() { "Oracle", "ASP.NET", "C#" }
        },
        new Employee
        {
            Index = 70,
            EmployeeNo = "2019-HR-9151",
            Name = "Pace Bryant",
            Email = "Bryant.Pace@example.com",
            Salary = 1601,
            Skills = new() { "CSS", "Javascript", "NodeJS", "Oracle", "SQL Server" }
        },
        new Employee
        {
            Index = 71,
            EmployeeNo = "2016-FI-1631",
            Name = "Watts Green",
            Email = "Green.Watts@example.com",
            Salary = 3303,
            Skills = new() { "ASP.NET", "Oracle" }
        },
        new Employee
        {
            Index = 72,
            EmployeeNo = "2014-AC-4574",
            Name = "Sonia Clarke",
            Email = "Clarke.Sonia@example.com",
            Salary = 2018,
            Skills = new() { "C#", "ASP.NET" }
        },
        new Employee
        {
            Index = 73,
            EmployeeNo = "2018-FI-2678",
            Name = "Donovan Brennan",
            Email = "Brennan.Donovan@example.com",
            Salary = 2436,
            Skills = new() { "SQL Server", "Javascript", "C#", "HTML" }
        },
        new Employee
        {
            Index = 74,
            EmployeeNo = "2016-IT-7173",
            Name = "Rutledge Harris",
            Email = "Harris.Rutledge@example.com",
            Salary = 1533,
            Skills = new() { "CSS", "C#", "ASP.NET" }
        },
        new Employee
        {
            Index = 75,
            EmployeeNo = "2021-FI-3360",
            Name = "Buckley Meyers",
            Email = "Meyers.Buckley@example.com",
            Salary = 3420,
            Skills = new() { "C#", "HTML", "Oracle", "Javascript" }
        }
    };
        }
    }



}

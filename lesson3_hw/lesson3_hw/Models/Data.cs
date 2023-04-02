using System.Collections.Generic;

namespace lesson3_hw.Models
{
    public static class Data
    {
        public static List <Service> Services = new List <Service>
        {
            new Service {Id=1,Title="Xidmetinizdeyik", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon = "bx bxl-dribbble"},
            new Service {Id=2,Title="Xidmetinizdeydik", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon = "bx bx-file"},
            new Service {Id=3,Title="Xidmetinizik", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon = "bx bx-tachometer"},
            new Service {Id=4,Title="Xidmetinizde", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon = "bx bx-world"},
            new Service {Id=5,Title="Xidmetinizden", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturis", Icon = "bx bx-slideshow"},
            new Service {Id=6,Title="Xidmetinizde ola bilerik", Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi", Icon = "bx bx-arch"}
        };
        public static List<Team> Teams = new List<Team> {
            new Team { Id=1, Name = "Amin Israfilzade", Occupation = "Back End Developer", Imgsrc = "/assets/img/team/team-1.jpg" },
            new Team { Id=2, Name = "Elvin Bilalov", Occupation = "Back End Developer", Imgsrc = "/assets/img/team/team-2.jpg"},
            new Team { Id=3, Name = "Maqsud Muslumov", Occupation = "Back End Developer", Imgsrc = "/assets/img/team/team-3.jpg"},
            new Team { Id=4, Name = "ABB", Occupation = "Back End Developer", Imgsrc = "/assets/img/team/team-4.jpg"}
        };
    }
}

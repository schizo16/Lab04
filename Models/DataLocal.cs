namespace Lab04.Models
{
    public class DataLocal
    {
        public static List<People> peoples = new List<People>()
        {
            new People()
            {
                Id = 0,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "1234567890",
                Address = "Ha Noi",
                Avatar = "/images/avatar/01.jpg",
                Birthday= Convert.ToDateTime("2012/09/22"),
                Bio = "Vien cong nghe Devmaster",
                Gender =2
            },
            new People()
            {
                Id = 1,
                Name = "TuanAnh",
                Email = "tuananh@gmail.com",
                Phone = "1234567890",
                Address = "Ha Noi",
                Avatar = "/images/avatar/02.jpg",
                Birthday= Convert.ToDateTime("2002/09/22"),
                Bio = "Vien cong nghe Devmaster",
                Gender =1
            },
            new People()
            {
                Id = 2,
                Name = "Guts",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "1234567890",
                Address = "Ha Noi",
                Avatar = "/images/avatar/03.jpg",
                Birthday= Convert.ToDateTime("1994/09/22"),
                Bio = "Vien cong nghe Devmaster",
                Gender =2
            },
            new People()
            {
                Id = 3,
                Name = "Doremon",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "1234567890",
                Address = "Ha Noi",
                Avatar = "/images/avatar/04.jpg",
                Birthday= Convert.ToDateTime("1984/09/22"),
                Bio = "Vien cong nghe Devmaster",
                Gender =1
            },
            new People()
            {
                Id = 4,
                Name = "Pikachu",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "1234567890",
                Address = "Ha Noi",
                Avatar = "/images/avatar/05.jpg",
                Birthday= Convert.ToDateTime("1985/09/22"),
                Bio = "Vien cong nghe Devmaster",
                Gender =2
            },
        };
        public static List<People> GetPeople()
        {
            return peoples;
        }
        public static People? GetPeopleById(int Id)
        {
            var people = peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }
    }
}

using Service.Helpers.Extentions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Services;
using Domain.Models;
using System.Text.RegularExpressions;

namespace LibraryApp.Controllers
{
    public class LibraryController
    {

        private readonly ILibraryService _libraryService;
        public LibraryController()
        {
            _libraryService = new LibraryService();
        }
        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add library name");
            Name: string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Dont be empty :");
                goto Name;
            }

            bool isMatch = Regex.IsMatch(name, @"\d");
            if (isMatch)
            {
                ConsoleColor.Red.WriteConsole("Dont add digit for name :");
                goto Name;
            }



            ConsoleColor.Cyan.WriteConsole("Add library seat count:");
            SeatCount: string seatCountStr = Console.ReadLine();

            int seatCount;

            bool isCorrectSeatCount = int.TryParse(seatCountStr, out seatCount);

            if(isCorrectSeatCount)
            {
                Library library = new()
                {
                    Name = name,
                    SeatCount = seatCount
                };

                _libraryService.Create(library);

                ConsoleColor.Green.WriteConsole("Library create success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add seat count format again :");
                goto SeatCount;
            }

        }


        public void GetAll()
        {
            var result  = _libraryService.GetAll();

            foreach (var item in result)
            {
                string data = $"{item.Id}  -  {item.Name}  -  {item.SeatCount}";
                ConsoleColor.Green.WriteConsole(data);
            }
        }


        public void GetById()
        {
            ConsoleColor.Cyan.WriteConsole("Add library id");
            Id: string idstr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idstr, out id);

            if(isCorrectId)
            {
                var resul = _libraryService.GetById(id);

                if(resul is null)
                {
                    ConsoleColor.Red.WriteConsole("Data not found, Write Id again :");
                    goto Id;
                }

                string data = $"{resul.Id}  -  {resul.Name}  -  {resul.SeatCount}";
                ConsoleColor.Green.WriteConsole(data);


            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add seat id format again :");
                goto Id;
            }
        }


    }
}

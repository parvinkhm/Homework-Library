﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        void Create(Library library);
        List<Library> GetAll();
        Library GetById(int id);
    }
}

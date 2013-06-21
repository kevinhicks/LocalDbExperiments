using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalDbExperiment.ViewModels.Home
{
    public class ListOfPeopleViewModel
    {
        public IEnumerable<Person> People { get; set; }
    }
}
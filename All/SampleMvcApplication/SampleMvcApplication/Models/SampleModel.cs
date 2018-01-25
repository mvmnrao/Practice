using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SampleMvcApplication.Models
{

    public class SampleModel
    {
        //
        // GET: /SampleModel/

        //public ActionResult SampleView()
        //{
        //    return View();
        //}

        string str = "";

        [DataType(DataType.Text)]
        [DisplayName("Give Some Text:")]
        [Required(ErrorMessage= "Please enter some text")]
        public string SomeString { get; set; }

        [DisplayName("You have entered:")]
        public string ReturnString { get; set; }
    }
}

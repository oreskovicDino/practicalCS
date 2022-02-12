﻿namespace EFDemoWeb.Pages
{
    using EFDataAccessLibrary.DataAccess;
    using EFDataAccessLibrary.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext db;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public void OnGet()
        {
            LoadSampleData();

            var people = db.People
                .Include(a => a.Addresses)
                .Include(e => e.EmailAddresses)
                .ToList();
        }

        private void LoadSampleData()
        {
            if (db.People.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var people = JsonSerializer.Deserialize<List<Person>>(file);
                db.AddRange(people);
                db.SaveChanges();
            }
        }
    }
}

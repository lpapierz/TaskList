﻿using TaskList.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TaskList.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TaskListDbContext _context;

        public InitialHostDbBuilder(TaskListDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

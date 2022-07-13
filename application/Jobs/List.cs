using domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace application.Jobs
{
    public class List
    {
        public class Query : IRequest<List<Job>> { }

        public class Handler : IRequestHandler<Query, List<Job>>
        {
            public async Task<List<Job>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await Task.Run(() =>
                {
                    var jobs = new List<Job>
                    {
                    new Job
                    {
                        Id = Guid.NewGuid(),
                        Title = "Techical Consultant",
                        Employer = "Microsoft",
                        Description = "As a Technical Consultant at Microsoft, I am responsible for implementing technical solutions using Dynamics 365 and the Power Platform for Microsoft customers.",
                        StartDate= new DateTime(2021,03,15),
                        EndDate = null
                    },
                    new Job
                    {
                        Id = Guid.NewGuid(),
                        Title = "Software Engineer",
                        Employer = "Northrop Grumman",
                        Description = "I contributed to a C++/Python codebase that was a simulation of a Global Hawk component. This sim allows for testing of other systems that interact with the component to utilize the sim rather than having to use the physical component for testing changes and stress testing of systems.",
                        StartDate= new DateTime(2019,07,22),
                        EndDate = new DateTime(2021,03,15)
                    },
                    new Job
                    {
                        Id = Guid.NewGuid(),
                        Title = "Software Developer",
                        Employer = "University of North Dakota",
                        Description = "I was a web application developer that built and supported .Net Framework/Core MVC and Web API applications built with C# and MSSQL databases. Additionally, began the transition to using Vue.js for our client-side web development and created a started template for it. Lastly, I supported our continuous integration and continuous deployment tools.",
                        StartDate= new DateTime(2018,08,13),
                        EndDate = new DateTime(2019,07,19),
                    },
                    new Job
                    {
                        Id = Guid.NewGuid(),
                        Title = "Associate Developer",
                        Employer = "Textron Aviation",
                        Description = "I worked in the Infrastructure department as a workstation admin and developer. I was responsible for business analysis on workstation deployments and development of business process automation using SQL databases, PowerShell scripting, and an off the shelf automation tool called i Request from PMG.",
                        StartDate= new DateTime(2017,01,23),
                        EndDate = new DateTime(2018,07,20),
                    }
                    };

                    return jobs;
                });
            }
        }
    }
}

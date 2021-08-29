using application.Jobs;
using domain;
using MediatR;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.Pages
{
    public class ExperienceBase : ComponentBase
    {
        [Inject]
        IMediator _mediator { get; set; }
        public List<Job> jobs = new List<Job>();

        protected override async Task OnInitializedAsync()
        {
            jobs = await _mediator.Send(new List.Query());
        }
    }
}

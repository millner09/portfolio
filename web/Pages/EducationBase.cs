using application.Education;
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
    public partial class EducationBase : ComponentBase
    {
        [Inject]
        IMediator _mediator { get; set; }
        public List<School> schoolRecords = new List<School>();

        protected override async Task OnInitializedAsync()
        {
            schoolRecords = await _mediator.Send(new List.Query());
        }
    }
}

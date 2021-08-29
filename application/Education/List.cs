using domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace application.Education
{
    public class List
    {
        public class Query : IRequest<List<School>> { }

        public class Handler : IRequestHandler<Query, List<School>>
        {
            public async Task<List<School>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await Task.Run(() =>
                {

                    var schoolRecords = new List<School>
                    {
                        new School
                        {
                            Id = Guid.NewGuid(),
                            Name = "University of North Dakota",
                            Degree = "B.S. Computer Science",
                            StartDate = new DateTime(2009,08,20),
                            EndDate = new DateTime(2017,12,16)
                        }
                    };

                    return schoolRecords;
                });
            }
        }
    }
}

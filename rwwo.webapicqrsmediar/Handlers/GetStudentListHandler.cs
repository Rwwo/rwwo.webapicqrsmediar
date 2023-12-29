using MediatR;
using rwwo.webapicqrsmediar.Models;
using rwwo.webapicqrsmediar.Queries;
using rwwo.webapicqrsmediar.Repositories;

namespace rwwo.webapicqrsmediar.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}

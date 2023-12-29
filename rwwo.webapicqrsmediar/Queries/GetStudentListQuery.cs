using MediatR;
using rwwo.webapicqrsmediar.Models;

namespace rwwo.webapicqrsmediar.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}

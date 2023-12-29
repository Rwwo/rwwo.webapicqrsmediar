using MediatR;
using rwwo.webapicqrsmediar.Models;

namespace rwwo.webapicqrsmediar.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}

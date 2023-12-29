using MediatR;

namespace rwwo.webapicqrsmediar.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

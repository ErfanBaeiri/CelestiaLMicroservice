using MediatR;
using System.ComponentModel.DataAnnotations;

namespace IDP.Application.Command.User
{
    public record UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "وارد نمودن نام الزامی است")]
        [MinLength(4, ErrorMessage = "نام باید حداقل 4 کاراکتر باشد")]
        public required string FullName { get; set; }
        public required string CodeNumber { get; set; }
    }
}

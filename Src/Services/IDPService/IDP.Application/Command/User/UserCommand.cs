using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Command.User
{
    public record UserCommand:IRequest<bool>
    {
        [Required(ErrorMessage ="اقا این داده الزامی است")]
        [MinLength(4)]
        public  string? FullName { get; set; }
        public  string? CodeNumber { get; set; }
        public  string? MobileNumber { get; set; }
    }
}

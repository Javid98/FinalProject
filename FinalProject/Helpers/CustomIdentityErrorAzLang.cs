using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Helpers
{
	public class CustomIdentityErrorAzLang : IdentityErrorDescriber
	{
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Code = nameof(PasswordRequiresDigit),
				Description = "Şifrədə ən az 1 rəqəm olmalıdır"

			};
		}
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError {
				Code = nameof(PasswordTooShort),
				Description= $"Şifrə minimum {length} simvoldan ibarət olmalıdır"
			};
		}
		public override IdentityError DuplicateUserName(string userName)
		{
			return new IdentityError
			{
				Code = nameof(DuplicateUserName),
				Description = $"'{userName}' başqa istifadəçiyə aiddir"
			};
		}
	}
}

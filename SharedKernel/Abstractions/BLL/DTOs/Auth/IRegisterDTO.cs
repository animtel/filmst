﻿namespace SharedKernel.Abstractions.BLL.DTOs.Auth
{
	public interface IRegisterDTO
	{
		string UserName { get; set; }
		string Password { get; set; }
	}
}

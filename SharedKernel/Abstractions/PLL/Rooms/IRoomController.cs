﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedKernel.Abstractions.BLL.DTOs.Media;
using SharedKernel.Abstractions.PLL.Rooms.Models;

namespace SharedKernel.Abstractions.PLL.Rooms
{
	public interface IRoomController
	{
		Task AddAsync(IAddRoomViewModel model);
		Task SignInAsync(ISignInRoomViewModel model);
		Task AddToRoomAsync(string roomName, string connectionId);
		string GetRoomName();
		string GetHostConnectionId();
		void DisconnectFromRoom();
		IEnumerable<IMediaDTO> CheckMedia(string roomName, IEnumerable<IMediaDTO> medias);
	}
}

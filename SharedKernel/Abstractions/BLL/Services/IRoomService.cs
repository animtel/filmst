﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedKernel.Abstractions.BLL.DTOs.Rooms;
using SharedKernel.Abstractions.DAL.Models;

namespace SharedKernel.Abstractions.BLL.Services
{
	public interface IRoomService
	{
		Task AddAsync(IAddRoomDTO dto);
		Task SignInAsync(ISignInRoomDTO dto);
		string GetRoomName();
		string GetHostConnectionId();
		Task DisconnectFromRoomAsync();
		Task AddToRoomAsync(string roomName, string connectionId);
		IEnumerable<IMedia> CheckMedia(string roomName, IEnumerable<IMedia> medias);
		IEnumerable<string> GetUserConnectionIdsInCurrentRoom();
		void MediaDownloaded(string roomName);
		bool IsAllUsersReadyToStart(string roomName);
	}
}

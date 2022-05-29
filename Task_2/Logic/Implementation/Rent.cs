﻿using Data.API;

namespace Logic.Implementation;

internal class Rent : IRent
{

    public string StateId { get; }
    public string UserId { get; }
    public string Id { get; set; }

    public Rent(string stateId, string userId)
    {
        StateId = stateId;
        UserId = userId;
    }
}
﻿namespace App.EnglishBuddy.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllUserResponse
{
   
    public string? Name { get; set; }
    public string? Mobile { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
}
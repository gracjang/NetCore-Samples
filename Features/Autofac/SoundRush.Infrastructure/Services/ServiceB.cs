﻿using SoundRush.Infrastructure.Services.Interfaces;

namespace SoundRush.Infrastructure.Services
{
  public class ServiceB : IServiceB
  {
    public string SendMessage()
    {
      return "Good morning, I am ServiceB";
    }
  }
}
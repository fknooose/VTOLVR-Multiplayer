﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[Serializable]
public class Message_MissileUpdate : Message
{
    public ulong networkUID;

    public Message_MissileUpdate(ulong uid)//unused, maybe usefull in the future
    {
        networkUID = uid;
        type = MessageType.MissileUpdate;
    }
}
﻿using System;
[Serializable]
public class Message_TurretUpdate : Message
{
    public SerializableVector3 direction;
    public ulong UID;
    public ulong turretID;

    public Message_TurretUpdate(Vector3D direction, ulong uID, ulong turretID)
    {
        this.direction = direction.toVector3;
        this.turretID = turretID;
        UID = uID;
        type = MessageType.TurretUpdate;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Plugin.BLE;
using Plugin.BLE.Abstractions;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.EventArgs;
using Plugin.BLE.Abstractions.Exceptions;
using Plugin.BLE.Abstractions.Extensions;

namespace MauiApp2.ViewModel;

public class Shot
{
    public int shot_id { get; set; }

    public long frame_id { get; set; }
    public long ball_id { get; set; }
    
    public long video_id { get; set; }
    public byte[] pins_remaining { get; set; }

    public string curTime { get; set; }
    //date time can be stored in a string variable if formatted correctly
    public byte[] laneNum { get; set; }

    public float[] ddx;

    public float[] ddy;

    public float[] ddz;


    public float[] x_pos;


    public float[] y_pos; 
    
    public float[] z_pos;




    public Shot(int identifier, long ballId)
    {
        shot_id = identifier;
        ball_id = ballId;
        pins_remaining = new byte[2];
        laneNum = new byte[2];
    }

    public void setzPosSize(int length)
    {
        z_pos = new float[length];
    }

    public void setyPosSize(int length)
    {
        y_pos = new float[length];
    }

    public void setxPosSize(int length)
    {
        x_pos = new float[length];
    }

    public void setddxSize(int length)
    {
        ddx = new float[length];
    }

    public void setddySize(int length)
    {
        ddy = new float[length];
    }

    public void setddzSize(int length)
    {
        ddz = new float[length];
    }

    public void setddz(int index, float input)
    {
        ddz[index] = input;
    }

    public void setddy(int index, float input)
    {
        ddy[index] = input;
    }

    public void setddx(int index, float input)
    {
        ddx[index] = input;
    }

    public void setxpos(int index, float input)
    {
        x_pos[index] = input;
    }

    public void setypos(int index, float input)
    {
        y_pos[index] = input;
    }

    public void setzpos(int index, float input)
    {
        z_pos[index] = input;
    }

    public float getzpos(int index)
    {
        return z_pos[index];
    }

    public float getxpos(int index)
    {
        return x_pos[index];
    }

    public float getypos(int index)
    {
        return y_pos[index];
    }

    public float getddz(int index)
    {
        return ddz[index];
    }

    public float getddx(int index)
    {
        return ddx[index];
    }

    public float getddy(int index)
    {
        return ddy[index];
    }
}

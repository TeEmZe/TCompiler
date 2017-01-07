﻿#region

using System.Collections.Generic;
using TCompiler.Types.CompilingTypes.ReturningCommand.Variable;

#endregion

namespace TCompiler.Settings
{
    /// <summary>
    /// Acutally not only settings but properties as well
    /// </summary>
    public static class GlobalSettings
    {
        /// <summary>
        /// A list of invalid names (for variables and methods)
        /// </summary>
        public static readonly List<string> InvalidNames = new List<string>
        {
            //"add",
            //"subb",
            //"inc",
            //"dec",
            //"mul",
            //"div",
            //"da",
            //"anl",
            //"orl",
            //"xrl",
            //"clr",
            //"cpl",
            //"mov",
            //"movc",
            //"movx",
            //"push",
            //"pop",
            //"xch",
            //"xchd",
            //"swap",
            //"nop",
            //"setb",
            //"rl",
            //"rlc",
            //"rr",
            //"rrc",
            //"call",
            //"ret",
            //"jmp",
            //"jz",
            //"jnz",
            //"jc",
            //"jnc",
            //"jb",
            //"jnb",
            //"jbc",
            //"cjne",
            //"djnz",
            //"data",
            //"bit",
            //"include",
            "int",
            "if",
            "endif",
            "bool",
            "while",
            "endwhile",
            "break",
            "block",
            "endblock",
            "fortil",
            "endfortil",
            "cint",
            "char",
            "return",
            "method",
            "endmethod",
            "sleep"
        };

        /// <summary>
        /// A list of the variables that can be used in T
        /// </summary>
        public static readonly List<Variable> StandardVariables = new List<Variable>
        {
            new Int(false, "080h", "Port0"),            //p0
            new Int(false, "081h", "StackPointer"),     //sp
            //new Int(false, "082h", "DataPointerLow"), //dpl 
            //new Int(false, "083h", "DataPointerHigh"),//dph
            new Int(false, "082h", "DataPointer0Low"),  //dp0l
            new Int(false, "083h", "DataPointer0High"), //dp0h
            new Int(false, "084h", "DataPointer1Low"),  //dp1l
            new Int(false, "085h", "DataPointer1High"), //dp1h
            new Int(false, "086h", "SPDR_Register"),    //spdr
            new Int(false, "087h", "PowerControl"),     //pcon
            new Int(false, "088h", "TimerControl"),     //tcon
            new Int(false, "089h", "TimerMode"),        //tmod
            new Int(false, "08Ah", "Timer0Low"),        //tl0
            new Int(false, "08Bh", "Timer1Low"),        //tl1
            new Int(false, "08Ch", "Timer0High"),       //th0
            new Int(false, "08Dh", "Timer1High"),       //th1
            new Int(false, "090h", "Port1"),            //p1
            new Int(false, "096h", "Watchdog_MemoryControlRegister"), //wmcon
            new Int(false, "098h", "SerialControl"),    //scon
            new Int(false, "099h", "SerialBuffer"),     //sbuf
            new Int(false, "0A0h", "Port2"),            //p2
            new Int(false, "0A8h", "InterruptEnable"),  //ie
            new Int(false, "0AAh", "SPSR_Register"),    //spsr
            new Int(false, "0B0h", "Port3"),            //p3
            new Int(false, "0B8h", "InterruptPriority"),//ip
            new Int(false, "0C8h", "Timer2Control"),    //t2con
            new Int(false, "0C9h", "Timer2Mode"),       //t2mod
            new Int(false, "0CAh", "rcap2l"),           //rcap2l    TODO
            new Int(false, "0CCh", "rcap2h"),           //rcap2h    TODO
            new Int(false, "0CCh", "Timer2Low"),        //tl2
            new Int(false, "0CDh", "Timer2High"),       //th2
            new Int(false, "0D0h", "ProgramStatusWorld"), //psw
            new Int(false, "0D5h", "SPCR_Register"),    //spcr
            new Int(false, "0E0h", "Accumulator"),      //acc
            new Int(false, "0F0h", "BRegister"),        //b
            //new Int(false, "0E0h", "a"),              //a
                //ProgramStatusWorld
            new Bool(false, "0D0h.7", "Carry"),         //cy
            new Bool(false, "0D0h.6", "AuxiliaryCarry"),//ac
            new Bool(false, "0D0h.5", "GeneralPurposeStatusFlag0"), //f0
            new Bool(false, "0D0h.4", "RegisterBankSelectBit1"), //rs1
            new Bool(false, "0D0h.3", "RegisterBankSelectBit0"), //rs0
            new Bool(false, "0D0h.2", "OverflowFlag"),  //ov
            new Bool(false, "0D0h.1", "GeneralPurposeStatusFlag1"), //f1
            new Bool(false, "0D0h.0", "ParityFlag"),             //p
                //TimerControl
            new Bool(false, "088h.7", "Timer1Overflow"),//tf1
            new Bool(false, "088h.6", "Timer1Run"),     //tr1
            new Bool(false, "088h.5", "Timer0Overflow"),//tf0
            new Bool(false, "088h.4", "Timer0Run"),     //tr0
            new Bool(false, "088h.3", "Interrupt1EdgeFlag"), //ie1
            new Bool(false, "088h.2", "Interrupt1SignalType"), //it1
            new Bool(false, "088h.1", "Interrupt0EdgeFlag"), //ie0
            new Bool(false, "088h.0", "Interrupt0SignalType"), //it0
                //InterruptEnable
            new Bool(false, "088h.7", "EA"),            //ea
            new Bool(false, "0A8h.5", "ET2"),           //et2
            new Bool(false, "0A8h.4", "ES"),            //es
            new Bool(false, "0A8h.3", "ET1"),           //et1
            new Bool(false, "0A8h.2", "EX1"),           //ex1
            new Bool(false, "0A8h.1", "ET0"),           //et0
            new Bool(false, "0A8h.0", "EX0"),           //ex0
                //InterruptPriority
            new Bool(false, "0B8h.5", "PT2"),           //pt2
            new Bool(false, "0B8h.4", "PS"),            //ps
            new Bool(false, "0B8h.3", "PT1"),           //pt1
            new Bool(false, "0B8h.2", "PX1"),           //px1
            new Bool(false, "0B8h.1", "PT0"),           //pt0
            new Bool(false, "0B8h.0", "PX0"),           //px0
                //Port3
            new Bool(false, "0B0h.7", "DataMemoryRead"),//rd
            new Bool(false, "0B0h.6", "DataMemoryWrite"), //wr
            new Bool(false, "0B0h.5", "Timer1ExternalInput"), //t1
            new Bool(false, "0B0h.4", "Timer0ExternalInput"), //t0
            new Bool(false, "0B0h.3", "Interrupt1"),    //int1
            new Bool(false, "0B0h.2", "Interrupt0"),    //int0
            new Bool(false, "0B0h.1", "SerialOutputPort"), //txd
            new Bool(false, "0B0h.0", "SerialInputPort"), //rxd
                //Timer2Control
            new Bool(false, "0C8h.7", "Timer2Overflow"),//tf2
            new Bool(false, "0C8h.6", "Timer2ExternalFlag"), //exf2
            new Bool(false, "0C8h.5", "ReceiveClockEnable"), //rclk
            new Bool(false, "0C8h.4", "TransmitClockEnable"), //tclk
            new Bool(false, "0C8h.3", "Timer2ExternalEnable"), //exen2
            new Bool(false, "0C8h.2", "Timer2Run"),     //tr2
            new Bool(false, "0C8h.1", "Counter_Timer2Select"), //c_t2
            new Bool(false, "0C8h.0", "Capture_Reload2Select"), //cp_rl2
                //SerialControl
            new Bool(false, "098h.7", "SM0"),           //sm0
            new Bool(false, "098h.6", "SM1"),           //sm1
            new Bool(false, "098h.5", "SM2"),           //sm2
            new Bool(false, "098h.4", "REN"),           //ren
            new Bool(false, "098h.3", "TB8"),           //tb8
            new Bool(false, "098h.2", "RB8"),           //rb8
            new Bool(false, "098h.1", "TI"),            //ti
            new Bool(false, "098h.0", "RI"),            //ri
                //Port1
            new Bool(false, "090h.7", "ClockInput_Output"), //sck
            new Bool(false, "090h.6", "DataInput_Output"), //miso
            new Bool(false, "090h.5", "DataOutput_Input"), //mosi
            new Bool(false, "090h.4", "SlavePortSelectInput"), //ss
            new Bool(false, "090h.1", "Timer_Counter2Capture_ReloadTrigger_DirectionControl"), //t2ex
            new Bool(false, "090h.0", "CountInputTimer_Counter2"), //t2
            //new Bool(false, "0D0h.7.", "c")           //c
        };

        public static string InputPath { get; set; }
        public static string OutputPath { get; set; }
        public static string ErrorPath { get; set; }
    }
}
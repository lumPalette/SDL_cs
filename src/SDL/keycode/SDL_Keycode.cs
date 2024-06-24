﻿namespace SDL_cs;

/// <summary>
/// The SDL virtual key representation.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">here</see> for more details.
/// </remarks>
public enum SDL_Keycode : uint
{
	Unknown = 0,
	Return = '\r',
	Escape = '\x1B',
	Backspace = '\b',
	Tab = '\t',
	Space = ' ',
	Exclaim = '!',
	DoubleApostrophe = '"',
	Hash = '#',
	Dollar = '$',
	Percent = '%',
	Ampersand = '&',
	Apostrophe = '\'',
	LeftParenthesis = '(',
	RightParenthesis = ')',
	Asterisk = '*',
	Plus = '+',
	Comma = ',',
	Minus = '-',
	Period = '.',
	Slash = '/',
	Row0 = '0',
	Row1 = '1',
	Row2 = '2',
	Row3 = '3',
	Row4 = '4',
	Row5 = '5',
	Row6 = '6',
	Row7 = '7',
	Row8 = '8',
	Row9 = '9',
	Colon = ':',
	Semicolon = ';',
	Less = '<',
	Equals = '=',
	Greater = '>',
	Question = '?',
	At = '@',
	LeftBracket = '[',
	Backslash = '\\',
	RightBracket = ']',
	Caret = '^',
	Underscore = '_',
	Grave = '`',
	A = 'a',
	B = 'b',
	C = 'c',
	D = 'd',
	E = 'e',
	F = 'f',
	G = 'g',
	H = 'h',
	I = 'i',
	J = 'j',
	K = 'k',
	L = 'l',
	M = 'm',
	N = 'n',
	O = 'o',
	P = 'p',
	Q = 'q',
	R = 'r',
	S = 's',
	T = 't',
	U = 'u',
	V = 'v',
	W = 'w',
	X = 'x',
	Y = 'y',
	Z = 'z',
	Capslock = SDL_Scancode.Capslock | SDL.ScancodeMask,
	F1 = SDL_Scancode.F1 | SDL.ScancodeMask,
	F2 = SDL_Scancode.F2 | SDL.ScancodeMask,
	F3 = SDL_Scancode.F3 | SDL.ScancodeMask,
	F4 = SDL_Scancode.F4 | SDL.ScancodeMask,
	F5 = SDL_Scancode.F5 | SDL.ScancodeMask,
	F6 = SDL_Scancode.F6 | SDL.ScancodeMask,
	F7 = SDL_Scancode.F7 | SDL.ScancodeMask,
	F8 = SDL_Scancode.F8 | SDL.ScancodeMask,
	F9 = SDL_Scancode.F9 | SDL.ScancodeMask,
	F10 = SDL_Scancode.F10 | SDL.ScancodeMask,
	F11 = SDL_Scancode.F11 | SDL.ScancodeMask,
	F12 = SDL_Scancode.F12 | SDL.ScancodeMask,
	Printscreen = SDL_Scancode.Printscreen | SDL.ScancodeMask,
	ScrollLock = SDL_Scancode.ScrollLock | SDL.ScancodeMask,
	Pause = SDL_Scancode.Pause | SDL.ScancodeMask,
	Insert = SDL_Scancode.Insert | SDL.ScancodeMask,
	Home = SDL_Scancode.Home | SDL.ScancodeMask,
	PageUp = SDL_Scancode.PageUp | SDL.ScancodeMask,
	Delete = SDL_Scancode.Delete | SDL.ScancodeMask,
	End = SDL_Scancode.End | SDL.ScancodeMask,
	PageDown = SDL_Scancode.PageDown | SDL.ScancodeMask,
	Right = SDL_Scancode.Right | SDL.ScancodeMask,
	Left = SDL_Scancode.Left | SDL.ScancodeMask,
	Down = SDL_Scancode.Down | SDL.ScancodeMask,
	Up = SDL_Scancode.Up | SDL.ScancodeMask,
	NumlockClear = SDL_Scancode.NumlockClear | SDL.ScancodeMask,
	KpDivide = SDL_Scancode.KpDivide | SDL.ScancodeMask,
	KpMultiply = SDL_Scancode.KpMultiply | SDL.ScancodeMask,
	KpMinus = SDL_Scancode.KpMinus | SDL.ScancodeMask,
	KpPlus = SDL_Scancode.KpPlus | SDL.ScancodeMask,
	KpEnter = SDL_Scancode.KpEnter | SDL.ScancodeMask,
	Kp1 = SDL_Scancode.Kp1 | SDL.ScancodeMask,
	Kp2 = SDL_Scancode.Kp2 | SDL.ScancodeMask,
	Kp3 = SDL_Scancode.Kp3 | SDL.ScancodeMask,
	Kp4 = SDL_Scancode.Kp4 | SDL.ScancodeMask,
	Kp5 = SDL_Scancode.Kp5 | SDL.ScancodeMask,
	Kp6 = SDL_Scancode.Kp6 | SDL.ScancodeMask,
	Kp7 = SDL_Scancode.Kp7 | SDL.ScancodeMask,
	Kp8 = SDL_Scancode.Kp8 | SDL.ScancodeMask,
	Kp9 = SDL_Scancode.Kp9 | SDL.ScancodeMask,
	Kp0 = SDL_Scancode.Kp0 | SDL.ScancodeMask,
	KpPeriod = SDL_Scancode.KpPeriod | SDL.ScancodeMask,
	Application = SDL_Scancode.Application | SDL.ScancodeMask,
	Power = SDL_Scancode.Power | SDL.ScancodeMask,
	KpEquals = SDL_Scancode.KpEquals | SDL.ScancodeMask,
	F13 = SDL_Scancode.F13 | SDL.ScancodeMask,
	F14 = SDL_Scancode.F14 | SDL.ScancodeMask,
	F15 = SDL_Scancode.F15 | SDL.ScancodeMask,
	F16 = SDL_Scancode.F16 | SDL.ScancodeMask,
	F17 = SDL_Scancode.F17 | SDL.ScancodeMask,
	F18 = SDL_Scancode.F18 | SDL.ScancodeMask,
	F19 = SDL_Scancode.F19 | SDL.ScancodeMask,
	F20 = SDL_Scancode.F20 | SDL.ScancodeMask,
	F21 = SDL_Scancode.F21 | SDL.ScancodeMask,
	F22 = SDL_Scancode.F22 | SDL.ScancodeMask,
	F23 = SDL_Scancode.F23 | SDL.ScancodeMask,
	F24 = SDL_Scancode.F24 | SDL.ScancodeMask,
	Execute = SDL_Scancode.Execute | SDL.ScancodeMask,
	Help = SDL_Scancode.Help | SDL.ScancodeMask,
	Menu = SDL_Scancode.Menu | SDL.ScancodeMask,
	Select = SDL_Scancode.Select | SDL.ScancodeMask,
	Stop = SDL_Scancode.Stop | SDL.ScancodeMask,
	Again = SDL_Scancode.Again | SDL.ScancodeMask,
	Undo = SDL_Scancode.Undo | SDL.ScancodeMask,
	Cut = SDL_Scancode.Cut | SDL.ScancodeMask,
	Copy = SDL_Scancode.Copy | SDL.ScancodeMask,
	Paste = SDL_Scancode.Paste | SDL.ScancodeMask,
	Find = SDL_Scancode.Find | SDL.ScancodeMask,
	Mute = SDL_Scancode.Mute | SDL.ScancodeMask,
	VolumeUp = SDL_Scancode.VolumeUp | SDL.ScancodeMask,
	VolumeDown = SDL_Scancode.VolumeDown | SDL.ScancodeMask,
	KpComma = SDL_Scancode.KpComma | SDL.ScancodeMask,
	KpEqualsAS400 = SDL_Scancode.KpEqualsAS400 | SDL.ScancodeMask,
	AltErase = SDL_Scancode.AltErase | SDL.ScancodeMask,
	SysReq = SDL_Scancode.SysReq | SDL.ScancodeMask,
	Cancel = SDL_Scancode.Cancel | SDL.ScancodeMask,
	Clear = SDL_Scancode.Clear | SDL.ScancodeMask,
	Prior = SDL_Scancode.Prior | SDL.ScancodeMask,
	Return2 = SDL_Scancode.Return2 | SDL.ScancodeMask,
	Separator = SDL_Scancode.Separator | SDL.ScancodeMask,
	Out = SDL_Scancode.Out | SDL.ScancodeMask,
	Oper = SDL_Scancode.Oper | SDL.ScancodeMask,
	ClearAgain = SDL_Scancode.ClearAgain | SDL.ScancodeMask,
	Crsel = SDL_Scancode.Crsel | SDL.ScancodeMask,
	Exsel = SDL_Scancode.Exsel | SDL.ScancodeMask,
	Kp00 = SDL_Scancode.Kp00 | SDL.ScancodeMask,
	Kp000 = SDL_Scancode.Kp000 | SDL.ScancodeMask,
	ThousandSeparator = SDL_Scancode.ThousandSeparator | SDL.ScancodeMask,
	DecimalSeparator = SDL_Scancode.DecimalSeparator | SDL.ScancodeMask,
	CurrencyUnit = SDL_Scancode.CurrencyUnit | SDL.ScancodeMask,
	CurrencySubUnit = SDL_Scancode.CurrencySubUnit | SDL.ScancodeMask,
	KpLeftParenthesis = SDL_Scancode.KpLeftParenthesis | SDL.ScancodeMask,
	KpRightParenthesis = SDL_Scancode.KpRightParenthesis | SDL.ScancodeMask,
	KpLeftBrace = SDL_Scancode.KpLeftBrace | SDL.ScancodeMask,
	KpRightBrace = SDL_Scancode.KpRightBrace | SDL.ScancodeMask,
	KpTab = SDL_Scancode.KpTab | SDL.ScancodeMask,
	KpBackspace = SDL_Scancode.KpBackspace | SDL.ScancodeMask,
	KpA = SDL_Scancode.KpA | SDL.ScancodeMask,
	KpB = SDL_Scancode.KpB | SDL.ScancodeMask,
	KpC = SDL_Scancode.KpC | SDL.ScancodeMask,
	KpD = SDL_Scancode.KpD | SDL.ScancodeMask,
	KpE = SDL_Scancode.KpE | SDL.ScancodeMask,
	KpF = SDL_Scancode.KpF | SDL.ScancodeMask,
	KpXOR = SDL_Scancode.KpXOR | SDL.ScancodeMask,
	KpPower = SDL_Scancode.KpPower | SDL.ScancodeMask,
	KpPercent = SDL_Scancode.KpPercent | SDL.ScancodeMask,
	KpLess = SDL_Scancode.KpLess | SDL.ScancodeMask,
	KpGreater = SDL_Scancode.KpGreater | SDL.ScancodeMask,
	KpAmpersand = SDL_Scancode.KpAmpersand | SDL.ScancodeMask,
	KpDoubleAmpersand = SDL_Scancode.KpDoubleAmpersand | SDL.ScancodeMask,
	KpVerticalBar = SDL_Scancode.KpVerticalBar | SDL.ScancodeMask,
	KpDoubleVerticalBar = SDL_Scancode.KpDoubleVerticalBar | SDL.ScancodeMask,
	KpColon = SDL_Scancode.KpColon | SDL.ScancodeMask,
	KpHash = SDL_Scancode.KpHash | SDL.ScancodeMask,
	KpSpace = SDL_Scancode.KpSpace | SDL.ScancodeMask,
	KpAt = SDL_Scancode.KpAt | SDL.ScancodeMask,
	KpExclaim = SDL_Scancode.KpExclaim | SDL.ScancodeMask,
	KpMemStore = SDL_Scancode.KpMemStore | SDL.ScancodeMask,
	KpMemRecall = SDL_Scancode.KpMemRecall | SDL.ScancodeMask,
	KpMemClear = SDL_Scancode.KpMemClear | SDL.ScancodeMask,
	KpMemAdd = SDL_Scancode.KpMemAdd | SDL.ScancodeMask,
	KpMemSubtract = SDL_Scancode.KpMemSubtract | SDL.ScancodeMask,
	KpMemMultiply = SDL_Scancode.KpMemMultiply | SDL.ScancodeMask,
	KpMemDivide = SDL_Scancode.KpMemDivide | SDL.ScancodeMask,
	KpPlusMinus = SDL_Scancode.KpPlusMinus | SDL.ScancodeMask,
	KpClear = SDL_Scancode.KpClear | SDL.ScancodeMask,
	KpClearEntry = SDL_Scancode.KpClearEntry | SDL.ScancodeMask,
	KpBinary = SDL_Scancode.KpBinary | SDL.ScancodeMask,
	KpOctal = SDL_Scancode.KpOctal | SDL.ScancodeMask,
	KpDecimal = SDL_Scancode.KpDecimal | SDL.ScancodeMask,
	KpHexadecimal = SDL_Scancode.KpHexadecimal | SDL.ScancodeMask,
	LCtrl = SDL_Scancode.LCtrl | SDL.ScancodeMask,
	LShift = SDL_Scancode.LShift | SDL.ScancodeMask,
	LGUI = SDL_Scancode.LGUI | SDL.ScancodeMask,
	RCtrl = SDL_Scancode.RCtrl | SDL.ScancodeMask,
	RShift = SDL_Scancode.RShift | SDL.ScancodeMask,
	RGUI = SDL_Scancode.RGUI | SDL.ScancodeMask,
	Mode = SDL_Scancode.Mode | SDL.ScancodeMask,
	AudioNext = SDL_Scancode.AudioNext | SDL.ScancodeMask,
	AudioPrev = SDL_Scancode.AudioPrev | SDL.ScancodeMask,
	AudioStop = SDL_Scancode.AudioStop | SDL.ScancodeMask,
	AudioPlay = SDL_Scancode.AudioPlay | SDL.ScancodeMask,
	AudioMute = SDL_Scancode.AudioMute | SDL.ScancodeMask,
	MediaSelect = SDL_Scancode.MediaSelect | SDL.ScancodeMask,
	WWW = SDL_Scancode.WWW | SDL.ScancodeMask,
	Mail = SDL_Scancode.Mail | SDL.ScancodeMask,
	Calculator = SDL_Scancode.Calculator | SDL.ScancodeMask,
	Computer = SDL_Scancode.Computer | SDL.ScancodeMask,
	AcSearch = SDL_Scancode.AcSearch | SDL.ScancodeMask,
	AcHome = SDL_Scancode.AcHome | SDL.ScancodeMask,
	AcBack = SDL_Scancode.AcBack | SDL.ScancodeMask,
	AcForward = SDL_Scancode.AcForward | SDL.ScancodeMask,
	AcStop = SDL_Scancode.AcStop | SDL.ScancodeMask,
	AcRefresh = SDL_Scancode.AcRefresh | SDL.ScancodeMask,
	AcBookmarks = SDL_Scancode.AcBookmarks | SDL.ScancodeMask,
	BrightnessDown = SDL_Scancode.BrightnessDown | SDL.ScancodeMask,
	BrightnessUp = SDL_Scancode.BrightnessUp | SDL.ScancodeMask,
	DisplaySwitch = SDL_Scancode.DisplaySwitch | SDL.ScancodeMask,
	KbdIllumToggle = SDL_Scancode.KbdIllumToggle | SDL.ScancodeMask,
	KbdIllumDown = SDL_Scancode.KbdIllumDown | SDL.ScancodeMask,
	KbdIllumUp = SDL_Scancode.KbdIllumUp | SDL.ScancodeMask,
	Eject = SDL_Scancode.Eject | SDL.ScancodeMask,
	Sleep = SDL_Scancode.Sleep | SDL.ScancodeMask,
	App1 = SDL_Scancode.App1 | SDL.ScancodeMask,
	App2 = SDL_Scancode.App2 | SDL.ScancodeMask,
	AudioRewind = SDL_Scancode.AudioRewind | SDL.ScancodeMask,
	AudioFastForward = SDL_Scancode.AudioFastForward | SDL.ScancodeMask,
	SoftLeft = SDL_Scancode.SoftLeft | SDL.ScancodeMask,
	SoftRight = SDL_Scancode.SoftRight | SDL.ScancodeMask,
	Call = SDL_Scancode.Call | SDL.ScancodeMask,
	EndCall = SDL_Scancode.EndCall | SDL.ScancodeMask,
}
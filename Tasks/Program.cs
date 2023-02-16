using ConsoleApp1;

IElectronicDevice electronicDevice = TvRemote.getDevice();

TurnTvOn onCommand = new TurnTvOn(electronicDevice);

DeviceButton onPressed = new DeviceButton(onCommand);

onPressed.Press();

TurnTvOff offCommand = new TurnTvOff(electronicDevice);

onPressed = new DeviceButton(offCommand);
onPressed.Press();

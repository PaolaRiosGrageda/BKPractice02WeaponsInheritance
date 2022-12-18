// See https://aka.ms/new-console-template for more information
using Jalasoft.DevLevel1.Practice2;

Console.WriteLine("Hello, World!");
// Shotgun
Weapon weaponSGun1= new Shotgun();
weaponSGun1.Name = NameWeapons.Shotgun;
Console.WriteLine(weaponSGun1.Name);
int magazineWeaponSGun1 = weaponSGun1.MagazineSize;
Console.WriteLine("The Shotgun has size magazine : {0}", magazineWeaponSGun1);

// Sniper Rifle
Weapon weaponSniperRifle1= new SniperRifle();
weaponSniperRifle1.Name=NameWeapons.SniperRifle;
Console.WriteLine(weaponSniperRifle1.Name);
int magazineWeaponSniper= weaponSniperRifle1.MagazineSize;
Console.WriteLine("The SniperRifle has size magazine: {0}", magazineWeaponSniper);


// Machine gun
Weapon weaponMachineGun1 = new MachineGun();
weaponMachineGun1.Name = NameWeapons.MachineGun;
Console.WriteLine(weaponMachineGun1.Name);
int magazineWeaponMachineGun = weaponMachineGun1.MagazineSize;
Console.WriteLine("The SniperRifle has size magazine: {0}", magazineWeaponMachineGun);


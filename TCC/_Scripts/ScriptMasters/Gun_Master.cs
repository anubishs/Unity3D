using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Master : MonoBehaviour {

	#region Variables
	public delegate void GeneralEventHandler();
	public event GeneralEventHandler EventPlayerInput;
	public event GeneralEventHandler EventGunNotUsable;
	public event GeneralEventHandler EventRequestReload;
	public event GeneralEventHandler EventRequestGunReset;

	public delegate void GunHitEventHandler(Vector3 hitPosition, Transform hitTranform);
	public event GunHitEventHandler EventShotDefault;
	public event GunHitEventHandler EventShotEnemy;

	public delegate void GunAmmoEventHandler(int currentAmmo, int carriedAmmo);
	public event GunAmmoEventHandler EventAmmoChanged;

	public bool isGunLoaded;
	public bool isLoading;
	#endregion

	#region Methods
	public void CallEventPlayerInput()
	{
		if (EventPlayerInput != null)
		{
			EventPlayerInput();
		}
	}

	public void CallEventGunNotUsable()
	{
		if (EventGunNotUsable != null)
		{
			EventGunNotUsable();
		}
	}

	public void CallEventRequestReload()
	{
		if (EventRequestReload != null)
		{
			EventRequestReload();
		}
	}

	public void CallEventRequestGunReset()
	{
		if (EventRequestGunReset != null)
		{
			EventRequestGunReset();
		}
	}

	public void CallEventShotDefault(Vector3 hPos, Transform hTransform)
	{
		if (EventShotDefault != null)
		{
			EventShotDefault(hPos, hTransform);
		}
	}

	public void CallEventShotEnemy(Vector3 hPos, Transform hTransform)
	{
		if (EventShotEnemy != null)
		{
			EventShotEnemy(hPos, hTransform);
		}
	}

	public void CallEventAmmoChanged(int curAmmo, int carAmmo)
	{
		if (EventAmmoChanged != null)
		{
			EventAmmoChanged(curAmmo, carAmmo);
		}
	}
	#endregion
}

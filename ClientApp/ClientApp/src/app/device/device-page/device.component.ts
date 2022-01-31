import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DeviceService } from 'src/app/shared/services/device.service';

@Component({
  selector: 'app-device',
  templateUrl: './device.component.html',
  styleUrls: ['./device.component.scss']
})
export class DeviceComponent implements OnInit {

  devices = [];

  constructor(private deviceService: DeviceService) { }
  ngOnInit(): void {
    this.deviceService.getDevices$().subscribe((x) => {
      this.devices = x;
      console.log(x);
    })
  }
}

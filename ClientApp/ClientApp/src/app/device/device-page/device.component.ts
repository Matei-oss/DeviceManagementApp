import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { DeviceService } from 'src/app/shared/services/device.service';

@Component({
  selector: 'app-device',
  templateUrl: './device.component.html',
  styleUrls: ['./device.component.scss']
})
export class DeviceComponent implements OnInit {
  displayedColumns: string[] = ['ID', 'Name', 'Mac Address', 'Firmware Version', 'Room'];
  
  devices = [];
  pageTitle = 'Devices';

  constructor(private deviceService: DeviceService,  private router: Router, private route: ActivatedRoute ) { }
  ngOnInit(): void {
    this.deviceService.getDevices$().subscribe((x) => {
      this.devices = x;
      console.log(x);
    })
  }

  onClick(){
    this.deviceService.getDevices$();
  }

  navigateToAddPage(){
    console.log(this.router);
    this.router.navigate(['add'],{relativeTo: this.route});
  }
}

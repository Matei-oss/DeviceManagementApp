import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeviceComponent } from './device-page/device.component';
import { DeviceRoutingModule } from './device-routing.module'



@NgModule({
  declarations: [
    DeviceComponent
  ],
  imports: [
    CommonModule,
    DeviceRoutingModule,
  ],
  exports:[
    DeviceComponent
  ],
  entryComponents:[
    DeviceComponent
  ]
})
export class DeviceModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddDeviceComponent } from './add-device/add-device.component';
import { DeviceComponent } from './device-page/device.component';


const routes: Routes = [
  {
    path: '',
    component: DeviceComponent
  },
  {
    path:'add',
    component: AddDeviceComponent
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DeviceRoutingModule { }

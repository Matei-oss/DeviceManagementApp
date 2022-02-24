import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeviceComponent } from './device-page/device.component';
import { DeviceRoutingModule } from './device-routing.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatInputModule} from '@angular/material/input';
import { SharedModule } from '../shared/shared.module';
import { AddDeviceComponent } from './add-device/add-device.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    DeviceComponent,
    AddDeviceComponent
  ],
  imports: [
    DeviceRoutingModule,
    FlexLayoutModule,
    SharedModule,
    CommonModule,
    ReactiveFormsModule
  ],
  exports:[
    DeviceComponent
  ],
  entryComponents:[
    DeviceComponent
  ]
})
export class DeviceModule { }

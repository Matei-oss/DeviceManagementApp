import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeviceComponent } from './device-page/device.component';
import { DeviceRoutingModule } from './device-routing.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatInputModule} from '@angular/material/input';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    DeviceComponent
  ],
  imports: [
    DeviceRoutingModule,
    FlexLayoutModule,
    SharedModule
  ],
  exports:[
    DeviceComponent
  ],
  entryComponents:[
    DeviceComponent
  ]
})
export class DeviceModule { }

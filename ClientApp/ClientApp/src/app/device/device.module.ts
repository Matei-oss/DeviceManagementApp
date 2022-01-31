import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeviceComponent } from './device-page/device.component';
import { DeviceRoutingModule } from './device-routing.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatInputModule} from '@angular/material/input';

@NgModule({
  declarations: [
    DeviceComponent
  ],
  imports: [
    CommonModule,
    DeviceRoutingModule,
    FlexLayoutModule,
    MatInputModule
  ],
  exports:[
    DeviceComponent
  ],
  entryComponents:[
    DeviceComponent
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class DeviceModule { }

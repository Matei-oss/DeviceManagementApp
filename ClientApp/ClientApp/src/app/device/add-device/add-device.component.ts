import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { DeviceService } from 'src/app/shared/services/device.service';

@Component({
  selector: 'app-add-device',
  templateUrl: './add-device.component.html',
  styleUrls: ['./add-device.component.scss']
})
export class AddDeviceComponent implements OnInit {


  form: FormGroup;
  constructor(private readonly fb: FormBuilder,private router: Router, private route: ActivatedRoute, private deviceService: DeviceService) { 
    this.form = this.fb.group({
      name: ['', Validators.required],
      macAddress: ['', Validators.required],
      firmwareVersion: ['', Validators.required]
    });
  }


  pageTitle = 'Add-Device';
  
  ngOnInit(): void {
  }
  navigateToAddPage(){
    console.log(this.router);
    this.router.navigate(['add'],{relativeTo: this.route});
  }

  submitForm(){
    if (this.form.valid){
      this.deviceService.addDevice$(this.form.getRawValue()).subscribe((value) => {
        console.log(value);
        this.router.navigate(['/device']);
      });
    } else {
      console.log('There is a problem with the form!');
      
    }
  }
}

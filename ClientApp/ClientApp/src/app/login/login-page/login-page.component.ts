import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { LoginService } from 'src/app/shared/services/login.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent implements OnInit {

  form: FormGroup;
  constructor(private readonly fb: FormBuilder, private loginService: LoginService ) {
    this.form = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
   }

  submitForm(){
    if (this.form.valid){
      this.loginService.login(this.form.getRawValue().username, this.form.getRawValue().password).subscribe((value) => {
        console.log(value);
      });
    } else {
      console.log('There is a problem with the form!');
    }
    
  }
  ngOnInit(): void {
  }

}

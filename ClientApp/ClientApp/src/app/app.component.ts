import { Component } from '@angular/core';
import { LoginService } from './shared/services/login.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ClientApp';

  constructor(private loginService: LoginService) {
 
  }

  public isUserLogged(): boolean{
    return this.loginService.isUserLogged();
  }
}


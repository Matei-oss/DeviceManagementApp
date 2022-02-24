import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


@Component({
  selector: 'app-app-page',
  templateUrl: './app-page.component.html',
  styleUrls: ['./app-page.component.scss']
})
export class AppPageComponent implements OnInit {

  @Input() title = '';
  @Output() onNavigate = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  public onNavigateClick(){
    this.onNavigate.emit('');
  }
}



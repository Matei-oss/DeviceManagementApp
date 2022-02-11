import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-app-page',
  templateUrl: './app-page.component.html',
  styleUrls: ['./app-page.component.scss']
})
export class AppPageComponent implements OnInit {

  @Input() title = '';
   
  constructor() { }

  ngOnInit(): void {
  }

}



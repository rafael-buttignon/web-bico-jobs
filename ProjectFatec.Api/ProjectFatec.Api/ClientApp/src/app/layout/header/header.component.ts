import { MatTreeNestedDataSource } from '@angular/material/tree';
import { NestedTreeControl } from '@angular/cdk/tree';
import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Location, LocationStrategy, PathLocationStrategy } from '@angular/common';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
  providers: [Location, { provide: LocationStrategy, useClass: PathLocationStrategy }]
})

export class HeaderComponent implements OnInit {
  selectedOption: string;
  isMobileMenuOpened = false;
  activateFxFlex = false;
  selectedIndex = 0;

  beforeFiltered: Array<HeaderNode> = [
    {
      label: 'Bico - Serviços',
      children: [
        { label: 'Sobre', children: [], isHighLighted: false, featureFlag: '', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'about' } },
        { label: 'Quem se beneficia?', children: [], isHighLighted: false, featureFlag: '', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'benefits' } },
        { label: 'Se Interessou?', children: [], isHighLighted: false, featureFlag: '', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'interested' } },
        { label: 'Dados participantes', children: [], isHighLighted: false, featureFlag: 'activateItemVersionTwo', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'participants' } }
      ],
      isHighLighted: true,
      featureFlag: '',
      path: '/sobre',
      externalUrl: '',
      redirectRouter: true,
      queryParams: {}
    },
    { label: 'Quero aderir', children: [], isHighLighted: true, featureFlag: 'activateItemVersionTwo', path: '/aderir', externalUrl: '', redirectRouter: false, queryParams: {} },
    { label: 'Sobre', children: [], isHighLighted: true, featureFlag: '', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'pressroom' } },
    { label: 'Login', children: [], isHighLighted: true, featureFlag: '', path: '/sobre', externalUrl: '', redirectRouter: false, queryParams: { view: 'thanks' } }
  ]

  treeControl = new NestedTreeControl<HeaderNode>(node => node.children);
  dataSource = new MatTreeNestedDataSource<HeaderNode>();
  tree: HeaderNode[] = this.filterFeatureFlag(this.beforeFiltered);

  constructor(
    private location: Location,
    private router: Router) {
    this.dataSource.data = this.tree;
    this.changeRoute();
  }

  changeRoute() {
    this.selectedIndex = (+this.location.path(true).substr(1) - 1) || 0;
    this.router.events.subscribe((event: any) => {
      if (event instanceof NavigationEnd) {
        if (event.url.includes('/termos-uso') ||
          event.url.includes('/privacidade') ||
          event.url.includes('/regulamentos') ||
          event.url.includes('/cancelamento')) {
          return;
        }
        this.selectedIndex = this.tree.findIndex(x => event.url.includes(x.path));
      }
    });
  }

  ngOnInit(): void {
    this.selectedOption = 'dashboard'
  }

  filterFeatureFlag(nodes: HeaderNode[]): HeaderNode[] {
    var filteredNodes: HeaderNode[] = [];
    nodes.forEach(x => {
      if (x.featureFlag.length == 0) {
        filteredNodes.push(x);
      }
      if (x.children.length > 0) {
        x.children = this.filterFeatureFlag(x.children);
        this.activateFxFlex = true;
      }
    });
    return filteredNodes;
  }

  hasChild = (_: number, node: HeaderNode) => !!node.children && node.children.length > 0;

  redirectToView(node: HeaderNode) {
    this.isMobileMenuOpened = false;
    if (node.externalUrl.length !== 0 && node.redirectRouter !== false) {
      this.router.navigate([''], { queryParams: node.queryParams });
      window.open(`${node.externalUrl}`, '_blank')
      return;
    }
    return this.router.navigate([node.path], { queryParams: node.queryParams });
  }
}

class HeaderNode {
  label: string;
  children: Array<HeaderNode>;
  isHighLighted: boolean;
  featureFlag: string;
  path: string;
  queryParams: Object;
  externalUrl: string;
  redirectRouter: boolean;
}

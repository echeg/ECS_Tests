using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System245 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component84> _p1;
EcsPool<Component329> _p2;
EcsPool<Component421> _p3;
EcsPool<Component484> _p4;
EcsPool<Component283> _pl0;
EcsPool<Component326> _pl1;
EcsPool<Component202> _pl2;
EcsPool<Component485> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component84>().Inc<Component329>().Inc<Component421>().Inc<Component484>().End();
   _p1 = _world.GetPool<Component84>();
   _p2 = _world.GetPool<Component329>();
   _p3 = _world.GetPool<Component421>();
   _p4 = _world.GetPool<Component484>();
   _pl0 = _world.GetPool<Component283>();
   _pl1 = _world.GetPool<Component326>();
   _pl2 = _world.GetPool<Component202>();
   _pl3 = _world.GetPool<Component485>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

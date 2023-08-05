using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System230 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component426> _p1;
EcsPool<Component100> _p2;
EcsPool<Component264> _p3;
EcsPool<Component299> _p4;
EcsPool<Component130> _pl0;
EcsPool<Component403> _pl1;
EcsPool<Component147> _pl2;
EcsPool<Component255> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component426>().Inc<Component100>().Inc<Component264>().Inc<Component299>().End();
   _p1 = _world.GetPool<Component426>();
   _p2 = _world.GetPool<Component100>();
   _p3 = _world.GetPool<Component264>();
   _p4 = _world.GetPool<Component299>();
   _pl0 = _world.GetPool<Component130>();
   _pl1 = _world.GetPool<Component403>();
   _pl2 = _world.GetPool<Component147>();
   _pl3 = _world.GetPool<Component255>();
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

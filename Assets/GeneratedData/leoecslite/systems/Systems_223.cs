using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System223 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component9> _p1;
EcsPool<Component293> _p2;
EcsPool<Component16> _p3;
EcsPool<Component70> _p4;
EcsPool<Component147> _pl0;
EcsPool<Component66> _pl1;
EcsPool<Component168> _pl2;
EcsPool<Component258> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component9>().Inc<Component293>().Inc<Component16>().Inc<Component70>().End();
   _p1 = _world.GetPool<Component9>();
   _p2 = _world.GetPool<Component293>();
   _p3 = _world.GetPool<Component16>();
   _p4 = _world.GetPool<Component70>();
   _pl0 = _world.GetPool<Component147>();
   _pl1 = _world.GetPool<Component66>();
   _pl2 = _world.GetPool<Component168>();
   _pl3 = _world.GetPool<Component258>();
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

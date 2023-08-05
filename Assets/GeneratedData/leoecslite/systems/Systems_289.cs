using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System289 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component114> _p1;
EcsPool<Component47> _p2;
EcsPool<Component116> _pl0;
EcsPool<Component448> _pl1;
EcsPool<Component380> _pl2;
EcsPool<Component407> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component114>().Inc<Component47>().End();
   _p1 = _world.GetPool<Component114>();
   _p2 = _world.GetPool<Component47>();
   _pl0 = _world.GetPool<Component116>();
   _pl1 = _world.GetPool<Component448>();
   _pl2 = _world.GetPool<Component380>();
   _pl3 = _world.GetPool<Component407>();
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

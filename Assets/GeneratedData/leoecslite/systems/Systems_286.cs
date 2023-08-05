using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System286 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component220> _p1;
EcsPool<Component382> _p2;
EcsPool<Component278> _p3;
EcsPool<Component87> _pl0;
EcsPool<Component432> _pl1;
EcsPool<Component428> _pl2;
EcsPool<Component353> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component220>().Inc<Component382>().Inc<Component278>().End();
   _p1 = _world.GetPool<Component220>();
   _p2 = _world.GetPool<Component382>();
   _p3 = _world.GetPool<Component278>();
   _pl0 = _world.GetPool<Component87>();
   _pl1 = _world.GetPool<Component432>();
   _pl2 = _world.GetPool<Component428>();
   _pl3 = _world.GetPool<Component353>();
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

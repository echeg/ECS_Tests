using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System74 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component294> _p1;
EcsPool<Component102> _p2;
EcsPool<Component231> _p3;
EcsPool<Component490> _p4;
EcsPool<Component337> _pl0;
EcsPool<Component262> _pl1;
EcsPool<Component102> _pl2;
EcsPool<Component336> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component294>().Inc<Component102>().Inc<Component231>().Inc<Component490>().End();
   _p1 = _world.GetPool<Component294>();
   _p2 = _world.GetPool<Component102>();
   _p3 = _world.GetPool<Component231>();
   _p4 = _world.GetPool<Component490>();
   _pl0 = _world.GetPool<Component337>();
   _pl1 = _world.GetPool<Component262>();
   _pl2 = _world.GetPool<Component102>();
   _pl3 = _world.GetPool<Component336>();
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

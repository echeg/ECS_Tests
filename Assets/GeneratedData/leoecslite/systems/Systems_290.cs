using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System290 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component105> _p1;
EcsPool<Component201> _p2;
EcsPool<Component129> _p3;
EcsPool<Component446> _pl0;
EcsPool<Component284> _pl1;
EcsPool<Component179> _pl2;
EcsPool<Component496> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component105>().Inc<Component201>().Inc<Component129>().End();
   _p1 = _world.GetPool<Component105>();
   _p2 = _world.GetPool<Component201>();
   _p3 = _world.GetPool<Component129>();
   _pl0 = _world.GetPool<Component446>();
   _pl1 = _world.GetPool<Component284>();
   _pl2 = _world.GetPool<Component179>();
   _pl3 = _world.GetPool<Component496>();
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

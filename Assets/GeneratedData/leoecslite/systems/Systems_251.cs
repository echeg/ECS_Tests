using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System251 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component175> _p1;
EcsPool<Component137> _p2;
EcsPool<Component114> _p3;
EcsPool<Component194> _p4;
EcsPool<Component318> _pl0;
EcsPool<Component322> _pl1;
EcsPool<Component129> _pl2;
EcsPool<Component293> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component175>().Inc<Component137>().Inc<Component114>().Inc<Component194>().End();
   _p1 = _world.GetPool<Component175>();
   _p2 = _world.GetPool<Component137>();
   _p3 = _world.GetPool<Component114>();
   _p4 = _world.GetPool<Component194>();
   _pl0 = _world.GetPool<Component318>();
   _pl1 = _world.GetPool<Component322>();
   _pl2 = _world.GetPool<Component129>();
   _pl3 = _world.GetPool<Component293>();
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

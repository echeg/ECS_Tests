using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System195 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component116> _p1;
EcsPool<Component82> _p2;
EcsPool<Component106> _p3;
EcsPool<Component419> _p4;
EcsPool<Component116> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component116>().Inc<Component82>().Inc<Component106>().Inc<Component419>().End();
   _p1 = _world.GetPool<Component116>();
   _p2 = _world.GetPool<Component82>();
   _p3 = _world.GetPool<Component106>();
   _p4 = _world.GetPool<Component419>();
   _pl0 = _world.GetPool<Component116>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}

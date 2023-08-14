using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System364 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component163> _p1;
EcsPool<Component63> _p2;
EcsPool<Component85> _p3;
EcsPool<Component234> _p4;
EcsPool<Component229> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().Inc<Component63>().Inc<Component85>().Inc<Component234>().End();
   _p1 = _world.GetPool<Component163>();
   _p2 = _world.GetPool<Component63>();
   _p3 = _world.GetPool<Component85>();
   _p4 = _world.GetPool<Component234>();
   _pl0 = _world.GetPool<Component229>();
 }
 public void Run (IEcsSystems systems) {
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

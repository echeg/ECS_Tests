using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System154 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component418> _p1;
EcsPool<Component41> _p2;
EcsPool<Component356> _p3;
EcsPool<Component76> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component418>().Inc<Component41>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component418>();
   _p2 = _world.GetPool<Component41>();
   _p3 = _world.GetPool<Component356>();
   _pl0 = _world.GetPool<Component76>();
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

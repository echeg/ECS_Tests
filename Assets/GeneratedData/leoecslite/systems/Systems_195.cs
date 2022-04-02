using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System195 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component50> _p1;
EcsPool<Component96> _p2;
EcsPool<Component192> _p3;
EcsPool<Component356> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component50>().Inc<Component96>().Inc<Component192>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component50>();
   _p2 = _world.GetPool<Component96>();
   _p3 = _world.GetPool<Component192>();
   _p4 = _world.GetPool<Component356>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
